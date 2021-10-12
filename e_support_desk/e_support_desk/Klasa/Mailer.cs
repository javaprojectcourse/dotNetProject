using System;
using System.Threading.Tasks;
using S22.Imap;
using System.Net.Mail;
using System.Configuration;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace e_support_desk
{
    public enum Tipi
    {
        kredenciale,
        id_ceshtje,
        rap_ceshtje,
        rap_ceshtje_mbyllur
    }

    class Mailer
    {
        private string email;
        private string fjalekalimi;
        private MailAddress from;
        private SmtpClient client;

        public Mailer()
        {
            email = "esuppdesk@gmail.com";
            fjalekalimi = "Q1w2e3r4.";
            from = new MailAddress(email);
            client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(email, fjalekalimi),
                EnableSsl = true
            };
        }

        public void Fillo()
        {
            Start_receiving();
        }

        public void Dergo_email(string to, Tipi tipi, string str1 = "", string str2 = "")
        {
            string subject, body;

            switch (tipi)
            {
                case Tipi.rap_ceshtje_mbyllur:
                    subject = "Ceshtje te ngjashme";
                    body = str1;
                    break;

                case Tipi.kredenciale:
                    subject = "Miresevini ne E-Support";
                    body = "Miresevini ne grupin e klienteve te E-Support!\n" +
                            "Kredencialet tuaja jane: \n" +
                            "Email: " + to.ToString() + "\n" +
                            "Fjalekalimi: " + str1 + "\n" +
                            "Me keto te dhena ju mund te aksesoni online ceshtjet tuaja aktive.\n" +
                            "Faleminderit!";
                    break;

                case Tipi.id_ceshtje:
                    subject = "Ceshtje e re E-Support";
                    body = "Ceshtja me te dhenat e meposhtme sapo u krijua.\n" +
                            "ID ceshtje: " + str1 + "\n" +
                            "Problemi: " + str2 + "\n" +
                            "Ju mund te nqiqni ecurine e ceshtjes ne faqen tone online ose duke na shkruar email me ID e ceshtjes ne subjekt.\n" +
                            "Faleminderit";
                    break;

                case Tipi.rap_ceshtje:
                    subject = "Ceshtje ne E-Support";
                    body = "I nderuar klient,\n" +
                            "Ne llogarine tuaj nuk ekziston ceshtje me id " + str1 + "!\n" +
                            "Ju lutem rishikoni emilet e meparshme.\n" +
                            "Faleminderit!";
                    //marrim te dhenat e ceshtjes nga databaza
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["e_support_conn_string"].ToString());
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "analize_ceshtje";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", str1);
                    cmd.Parameters.AddWithValue("email", to);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            body = "Pershendetje " + reader["klienti"].ToString() + "!\n";
                            body += "Gjendja e ceshtjes nr." + str1 + " eshte si me poshte :\n";
                            body += "Ceshtja: " + reader["lloji"].ToString() + "\n";
                            body += "Statusi: " + reader["pershkrimi"].ToString() + "\n";
                            body += "Afati kohor: " + reader["afati_kohor"].ToString() + "\n";
                            body += "Pergjegjesi: " + reader["pergjegjesi"].ToString() + "\n";
                            body += "Faleminderit!";
                        }
                        reader.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    break;

                default:
                    return;
            }

            MailAddress send_to = new MailAddress(to);
            MailMessage message = new MailMessage(from, send_to){
                                                                    Subject = subject,
                                                                    Body = body
                                                                };
            try
            {
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private int get_id_ceshtje(string subject, string to)
        {
            subject = subject.Trim();
            int id = 0;
            try
            {
                id = Convert.ToInt32(subject);
                return id;
            }
            catch (Exception ex)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["e_support_conn_string"].ToString());
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select id_sherbimi from analize_ceshtjesh_mbyllur where sherbimi like '%@text%'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@text", subject);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    HashSet<int> sherbimet = new HashSet<int>();
                    while (reader.Read())
                    {
                        sherbimet.Add((int)reader["id_sherbimi"]);
                    }
                    if (sherbimet.Count != 0)
                    {
                        Dergo_raport_historik(sherbimet, to);
                    }
                }
                catch (Exception e)
                {
                    //exc ne gjetje sherbimi
                }
            }
            return id = 0;
        }


        public void Dergo_raport_historik(HashSet<int> sherbimet, string to)
        {
            string mesazhi = "Ekzistojne ceshtje te ngjashme ne databaze:\n";
            foreach (int i in sherbimet)
            {
                mesazhi += merr_analize_sherbimi(i);
            }
            Dergo_email(to, Tipi.rap_ceshtje_mbyllur, mesazhi);
        }

        private string merr_analize_sherbimi(int id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["e_support_conn_string"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select avg(dite_mes) as avg, sherbimi from analize_ceshtjesh_mbyllur" +
                " where id_sherbimi=@id" +
                "group by sherbimi";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string mesazhi = "";
            while (reader.Read())
            {
                mesazhi = "Sherbimi " + reader["sherbimi"] + "zgjidhet per mesatarisht " + reader["avg"] + " dite.\n";
            }
            conn.Close();
            return mesazhi;
        }

        private void Start_receiving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993,
                    email, fjalekalimi, AuthMethod.Login, true))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        Console.WriteLine("server does not support imap idle");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(On_new_message);
                    while (true) ;
                }
            });
        }

        private void On_new_message(object sender, IdleMessageEventArgs e)
        {
            Console.WriteLine("New message");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);

            int id = get_id_ceshtje(m.Subject, m.From.ToString());
            if (id > 0)
                Dergo_email(m.From.ToString(), Tipi.rap_ceshtje, id.ToString(), "Te dhenat mbi ecurine e ceshtjes");
        }
    }
}

