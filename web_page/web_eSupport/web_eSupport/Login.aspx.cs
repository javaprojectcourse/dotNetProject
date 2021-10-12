using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Security.Cryptography;

namespace web_eSupport
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private string Hush_Fjalekalimi(string fjalekalimi)
        {
            byte[] fjkl_bytes = System.Text.Encoding.UTF8.GetBytes(fjalekalimi);
            string fjkl_hush = "";

            using (SHA1Managed sha1 = new SHA1Managed())
            {
                fjkl_hush = Convert.ToBase64String(sha1.ComputeHash(fjkl_bytes));
            }
            return fjkl_hush;
        }

        protected void btn_hyr_Click1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select id_klienti from klienti where email=@email and fjalekalimi=@fjalekalimi";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", txt_email.Value.Trim());
            cmd.Parameters.AddWithValue("@fjalekalimi", Hush_Fjalekalimi(txt_fjalekalimi.Value.Trim()));
            int id_klienti = 0;
            try
            {
                conn.Open();
                if (cmd.ExecuteScalar() == null)
                {
                    lbl_error_msg.InnerText = "Te dhena te gabuara!";
                    lbl_error_msg.Visible = true;
                    return;
                }
                id_klienti = (int)cmd.ExecuteScalar();
                Session["id_klienti"] = id_klienti;
                Response.Redirect("ceshtjetOnline.aspx");
            }
            catch (Exception ex)
            {
                lbl_error_msg.InnerText = ex.Message;
                lbl_error_msg.Visible = true;
                return;
            }
            conn.Close();
        }
    }
}