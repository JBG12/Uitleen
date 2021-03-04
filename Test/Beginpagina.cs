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
    public partial class Beginpagina : Form
    {

        private MySqlConnection connection;

        public Beginpagina()
        {
            InitializeComponent();

            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string server = "localhost";
            string database = "apparaten";
            string dbUsername = "root";
            string dbPassword = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            connection = new MySqlConnection(connectionString);
        }


        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Hier wordt de verbinding met de database weer verbroken.
        /// </summary>
        /// <returns></returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inleveren inleveren = new Inleveren(); //Maakt een nieuw exemplaar van Form2
            this.Hide(); //Hiermee wordt het oude venster verborgen 
            inleveren.ShowDialog(); //Hiermee laat je het opgevraagde venster zien 
            this.Close(); //Hiermee wordt het oude venster gesloten
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uitlenen uitlenen = new Uitlenen(); //Maakt een nieuw exemplaar van Form2
            this.Hide(); //Hiermee wordt het oude venster verborgen 
            uitlenen.ShowDialog(); //Hiermee laat je het opgevraagde venster zien 
            this.Close(); //Hiermee wordt het oude venster gesloten
        }

        private void button3_Click(object sender, EventArgs e)
        {



            Apparatenlijst apparatenlijst = new Apparatenlijst(); //Maakt een nieuw exemplaar van Form2
            this.Hide(); //Hiermee wordt het oude venster verborgen 
            apparatenlijst.ShowDialog(); //Hiermee laat je het opgevraagde venster zien 
            this.Close(); //Hiermee wordt het oude venster gesloten
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
