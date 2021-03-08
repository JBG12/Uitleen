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

namespace uitleen
{
    public partial class inleveren : Form
    {
        string MyConnectionString = "Server=localhost;Database=apparatuur;Uid=root;Pwd=";
        public inleveren()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apparaat = apparaatt.Text;
            string leerlingnummer = leerlingnummert.Text;
            string opmerking = opmerkingt.Text;

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO lijst(apparaatnaam, uitlener, opmerkingen) VALUES(@apparaatnaam, @uitlener, @opmerking)";
                cmd.Parameters.AddWithValue("@apparaatnaam", apparaatt.Text);
                cmd.Parameters.AddWithValue("@uitlener", leerlingnummert.Text);
                cmd.Parameters.AddWithValue("@opmerking", opmerkingt.Text);
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
                    //loaddata();

                    MessageBox.Show("U heeft uw apparaat met succes ingeleverd");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

