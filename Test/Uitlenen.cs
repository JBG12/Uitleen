using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Uitlenen : Form
    {
        string MyConnectionString = "Server=localhost;Database=apparatuur;Uid=root;Pwd=;";

        public Uitlenen()
        {
            InitializeComponent();
        }

        private void Uitlenen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uitleen_Click(object sender, EventArgs e)
        {
            string nummerr = nummert.Text;
            string apparaatt = apparaatr.Text;
           

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE lijst SET uitgeleend='Uitgeleend' WHERE apparaatnaam=(@apparaatnaam)";
                cmd.Parameters.AddWithValue("@apparaatnaam", apparaatt);
                cmd.CommandText = "UPDATE lijst SET uitlener=(@uitgeleend) WHERE apparaatnaam=(@apparaatnaam)";
                cmd.Parameters.AddWithValue("@uitgeleend", nummerr);
                cmd.CommandText = "UPDATE lijst SET uitgeleend=(@setstatus)";
                cmd.Parameters.AddWithValue("@setstatus", "Uitgeleend ✗");
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                    MessageBox.Show("Apparaat succesvol uitgeleend");
                }
            }
        }

        private void apparaatr_TextChanged(object sender, EventArgs e)
        {

        }

        private void nummert_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
