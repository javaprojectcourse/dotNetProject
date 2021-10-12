using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace e_support_desk
{
    public partial class Login : Form
    {
        private string conn_string = "Data Source=DESKTOP-ENDPDP1;Initial Catalog=databaza;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_hyr_Click(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                MessageBox.Show(this, "Vendosni email-in!", "Error");
                return;
            }
            else if (fjalekalimi.Text == "")
            {
                MessageBox.Show(this, "Vendosni fjalekalimin!", "Error");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "get_user_id";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("email", email.Text);
                cmd.Parameters.AddWithValue("fjalekalimi", fjalekalimi.Text);
                int id_punonjesi = 0;
                try
                {
                    conn.Open();
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show(this, "Te dhena te gabuara!", "Error");
                        fjalekalimi.Text = "";
                        return;
                    }
                    id_punonjesi = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }

                //ekziston useri
                //do te hapet forma e rradhes
                Menu menu = new Menu(id_punonjesi, conn_string);
                this.Visible = false;
                menu.ShowDialog();
                this.Dispose();
            }
        }


        //enkriptimi i fjalekalimit
       /* private string Hush_Fjalekalimi()
        {
            byte[] fjkl_bytes = System.Text.Encoding.UTF8.GetBytes(fjalekalimi.Text);
            string fjkl_hush = "";

            using (SHA1Managed sha1 = new SHA1Managed())
            {
                fjkl_hush = Convert.ToBase64String(sha1.ComputeHash(fjkl_bytes));
            }
            return fjkl_hush;
        }*/

    }
}
