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
    public partial class Apparatenlijst : Form
    {
        string MyConnectionString = "Server=localhost;Database=apparaten;Uid=root;Pwd=;";

        public Apparatenlijst()
        {
            InitializeComponent();

        }

        private void Apparatenlijst_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string apparaatt = toevoegg.Text;

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO lijst(apparaat)VALUES(@apparaat)";
                cmd.Parameters.AddWithValue("@apparaat", apparaatt);
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
                  //  LoadData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void verwijder_Click(object sender, EventArgs e)
        {

            string apparaata = verwijderr.Text;

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM lijst WHERE apparaat=@apparaat";
                cmd.Parameters.AddWithValue("@apparaat", apparaata);
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
                    //  LoadData();
                    MessageBox.Show("Apparaat succesvol verwijderd");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
