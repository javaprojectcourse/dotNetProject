using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace web_eSupport
{
    public partial class ceshtjetOnline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_klienti"] == null)
                Response.Redirect("Login.aspx");
            update_faqen();
        }

        //lexo te dhenat ne databaze
        private SqlDataReader lexo_ceshtjetDB()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "analize_ceshtjesh_tegjitha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", Session["id_klienti"]);

            SqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                id_tbody.InnerHtml = "Error: " + ex.Message;
            }
            conn.Close();
            return reader;
        }

        private string formato_te_dhenat(SqlDataReader reader)
        {
            StringBuilder sb = new StringBuilder();
            int id_ceshtje = 0;
            if(reader != null)
            {
                while(reader.Read())
                {

                    sb.AppendLine("<tr>");
                    sb.AppendLine("<td>" + reader["lloji"].ToString() + "</td>");
                    sb.AppendLine("<td>" + reader["pershkrimi"].ToString() + "</td>");
                    sb.AppendLine("<td>" + reader["pergjegjesi"].ToString() + "</td>");
                    sb.AppendLine("<td>" + reader["afati_kohor"].ToString() + "</td>");

                    //kerkimi per kerkesa per shtyrjw afatesh
                    id_ceshtje = (int)reader["id_ceshtje"];
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from krk_sh_afati where id_ceshtje=@id and pranuar is null;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id_ceshtje);

                    SqlDataReader r = null;
                    try
                    {
                        conn.Open();
                        r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            sb.AppendLine("<td>" + r["afati_ri"].ToString() + "</td>");
                            sb.AppendLine("<td><form action='index.aspx' runat='server' onserverclick='redirect()'><button type='button' class='btn btn-success'>Prano</button></form></td>");
                            sb.AppendLine("<td><form runat='server'><button type='button' class='btn btn-danger'>Refuzo</button></form></td>");
                        }
                        r.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    conn.Close();
                    sb.AppendLine("</tr>");

                }

                reader.Close();
            }
            return sb.ToString();
        }

        
        public void redirect(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        private void update_faqen()
        {
            id_tbody.Controls.Add(new LiteralControl(formato_te_dhenat(lexo_ceshtjetDB())));
        }
    }
}