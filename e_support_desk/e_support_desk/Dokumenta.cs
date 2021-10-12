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
    public partial class Dokumenta : Form
    {
        private string conn_string;
        public Dokumenta(string conn_str)
        {
            InitializeComponent();
            conn_string = conn_str;
            update_statistikat();
        }

        private void update_statistikat()
        {
            //nr i diteve mesatare te zhvendosjes nga afati praprak per zgjidhjen e ceshtjeve
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "Select coalesce(avg(DATEDIFF(day, GETDATE(),afati_kohor)), 0) as dite " +
                                    "from ceshtja where statusi = 2 OR statusi = 3";
                cmd1.CommandType = CommandType.Text;

                try
                {
                    conn.Open();
                    int nr_ditesh = (int)cmd1.ExecuteScalar();
                    txt_dite.Text = nr_ditesh.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }

            //nr i ceshtjeve per prioritet
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "Select prioriteti, count(id_ceshtje) as nr_ceshtjesh " +
                                    "from ceshtja group by prioriteti";
                cmd1.CommandType = CommandType.Text;

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    List<string> prioritetet = new List<string>();
                    while(reader.Read())
                    {
                        prioritetet.Add(reader[1].ToString());
                    }
                    txt_p1.Text = prioritetet[0];
                    txt_p2.Text = prioritetet[1];
                    txt_p3.Text = prioritetet[2];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }

        private void dokumentimBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dokumentimBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.e_supportDataSet);

        }

        private void Dokumenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.dokumentim' table. You can move, or remove it, as needed.
            this.dokumentimTableAdapter.Fill(this.e_supportDataSet.dokumentim);

        }

    
    }
}
