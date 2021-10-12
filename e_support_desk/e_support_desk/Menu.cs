using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_support_desk
{
    public partial class Menu : Form
    {
        private string conn_string;
        private int id_perdoruesi;
        private int roli;
        public Menu(int id, string conn_str)
        {
            InitializeComponent();
            id_perdoruesi = id;
            conn_string = conn_str;
            get_roli();
            lbl_perdoruesi_update();
            lbl_vonesa_update();

            //ndalo aksesin e plote te cdo punonjesi
            if (roli != 1)
            {
                btn_regj_pun.Enabled = false;
                btn_raporte.Enabled = false;
            }
        }

        private void get_roli()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select id_roli from punonjesi where id_punonjesi = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id_perdoruesi);
                try
                {
                    conn.Open();
                    roli = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }


        //metoda qe shkruan emrin dhe rolin e perdoruesit aktual ne dritaren Menu
        private void lbl_perdoruesi_update()
        {
            //update i labelave me emrin dhe rolin
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "Select CONCAT(emri, ' ', mbiemri) from punonjesi " +
                                   "where id_punonjesi=@id";
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@id", id_perdoruesi);

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "Select pozicioni from roli where vlera=@id_roli";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@id_roli", id_perdoruesi);
                try
                {
                    conn.Open();
                    lbl_perdoruesi.Text = (string)cmd1.ExecuteScalar();
                    lbl_roli.Text = (string)cmd2.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }

        //shfaq ne dritare nr e ceshtjeve te punonjesit me 1 dite te mbetur afati zgjidhje ose afat te tejkaluar
        private void lbl_vonesa_update()
        {
            //update i labelit me vonesat
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "vonesa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_perdoruesi);
                try
                {
                    conn.Open();
                    int nr_vonesash = cmd.ExecuteNonQuery();
                    lbl_vonesa.Text = (nr_vonesash == -1) ? "0" : nr_vonesash.ToString();
                    if (nr_vonesash >= 1)
                        lbl_vonesa.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            //nisim threadin qe pret pergjigjet ne gmail dhe pergjigjet automatikisht
            Mailer mailer = new Mailer();
            mailer.Fillo();
        }

        private void btn_regj_pun_Click(object sender, EventArgs e)
        {
            New_Perdorues new_perd_window = new New_Perdorues(conn_string);
            this.Visible = false;
            new_perd_window.ShowDialog();
            this.Visible = true;
        }


        private void btn_regj_sher_Click(object sender, EventArgs e)
        {
            New_Sherbim new_sher_window = new New_Sherbim(conn_string, roli);
            this.Visible = false;
            new_sher_window.ShowDialog();
            this.Visible = true;
        }


        private void btn_regj_paj_Click(object sender, EventArgs e)
        {
            New_Pajisje new_paj_window = new New_Pajisje(conn_string, roli);
            this.Visible = false;
            new_paj_window.ShowDialog();
            this.Visible = true;
        }

        private void btn_dil_Click(object sender, EventArgs e)
        {
            Login login_window = new Login();
            this.Visible = false;
            login_window.ShowDialog();
            this.Dispose();
        }

        private void btn_shitje_Click(object sender, EventArgs e)
        {
            Faturim fat_window = new Faturim(conn_string, id_perdoruesi);
            this.Visible = false;
            fat_window.ShowDialog();
            this.Visible = true;
        }

        private void btn_hap_cesh_Click(object sender, EventArgs e)
        {
            New_Ceshtje new_ticket_window = new New_Ceshtje(conn_string);
            this.Visible = false;
            new_ticket_window.ShowDialog();
            this.Visible = true;
        }

        private void btn_cesh_hapur_Click(object sender, EventArgs e)
        {
            Ceshtje cesh_window = new Ceshtje(conn_string, id_perdoruesi);
            this.Visible = false;
            cesh_window.ShowDialog();
            this.Visible = true;
        }

        private void btn_raporte_Click(object sender, EventArgs e)
        {
            Dokumenta doc_window = new Dokumenta(conn_string);
            this.Visible = false;
            doc_window.ShowDialog();
            this.Visible = true;
        }
    }
}
