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

                    MessageBox.Show("Apparaat succesvol toegevoegd");
                }
            }
        }

<<<<<<< HEAD
        private bool OpenConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
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
                        MessageBox.Show("Kan niet verbinden met de server");
                        break;

                    case 1045:
                        MessageBox.Show("Onjuist wachtwoord en/of gebruikersnaam, probeer het opnieuw");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// In deze functie wordt een SQL-statement uitgevoerd. 
        /// De resultaten worden worden teruggestuurd naar de aanroeper van deze functie.
        /// </summary>
        /// <returns>Er worden lijsten van studenten teruggegeven.</returns>
        public List<string>[] GetInfoDB()
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            string sqlQuery = "SELECT * FROM lijst";

            connection.Open();
            // Maak een lijst aan voor 3 posities ('Apparaatnaam', 'Uitgeleend-status', 'Uitlener')
            List<string>[] resultlist = new List<string>[3];
            resultlist[0] = new List<string>();
            resultlist[1] = new List<string>();
            resultlist[2] = new List<string>();

            // Open de connectie naar de database om gegevens op te halen.
            if (this.OpenConnection() == true)
            {
                // Om gegevens op te halen hebben een een opdracht nodig om dit op te halen (dit doen we met een MySqlCommand).
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                // Om resultaten (van de MySqlCommand) uit te lezen maken we gebruik van een reader.
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // We lezen de resultaten uit en stoppen deze in een variable.
                while (dataReader.Read())
                {
                    resultlist[0].Add(dataReader["apparaatnaam"] + "");
                    resultlist[1].Add(dataReader["uitgeleend"] + "");
                    resultlist[2].Add(dataReader["uitlener"] + "");
                }

                // We zijn klaar met het lezen dus we kunnen hier de datareader sluiten.
                dataReader.Close();

                // Na het sluiten van de reader sluit ook de verbinding naar de database.
                connection.Close();

                // We geven de gevonden de resultaten terug aan de code die deze functie geeft uitgeroepen.
                return resultlist;
            }
            else
            {
                // Als er geen verbinding geopend is, kunnen we ook niets uit de database lezen. Dus geef hier maar een lege variabele terug.
                return resultlist;
            }
        }

=======
>>>>>>> parent of ba655aa (mmhhh)
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
                 
                    MessageBox.Show("Apparaat succesvol verwijderd");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
