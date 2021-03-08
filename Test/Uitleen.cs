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
    public partial class Uitleen : Form
    {
        string MyConnectionString = "Server=localhost;Database=apparatuur;Uid=root;Pwd=;";
        public Uitleen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE lijst SET uitlener=(@uitgeleend) WHERE apparaatnaam=(@apparaatnaam)";
                cmd.Parameters.AddWithValue("@uitgeleend", nummerr);
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

        private void terugg_Click(object sender, EventArgs e)
        {
            Beginpagina beginpagina = new Beginpagina(); //Maakt een nieuw exemplaar van Form2
            this.Hide(); //Hiermee wordt het oude venster verborgen 
            beginpagina.ShowDialog(); //Hiermee laat je het opgevraagde venster zien 
            this.Close(); //Hiermee wordt het oude venster gesloten
        }

        private void nummert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
