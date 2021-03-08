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
        string MyConnectionString = "Server=localhost;Database=apparatuur;Uid=root;Pwd=;";


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
                cmd.CommandText = "INSERT INTO lijst(apparaatnaam)VALUES(@apparaatnaam)";
                cmd.Parameters.AddWithValue("@apparaatnaam", apparaatt);
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
            resultlist[3] = new List<string>();

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
                    resultlist[3].Add(dataReader["opmerkingen"] + "");
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
                cmd.CommandText = "DELETE FROM lijst WHERE apparaatnaam=@apparaatnaam";
                cmd.Parameters.AddWithValue("@apparaatnaam", apparaata);
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

        private void Lijst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // maak eerst de bestaande lijst met gegevens leeg.
            Lijst.Items.Clear();

            // Roep de functie aan die alle apparaten ophaalt uit de database.
            List<string>[] alleInfo = GetInfoDB();

            // Doorloop alle resultaten en voeg iedere gebruiker toe aan de lijst.
            for (int i = 0; i < alleInfo[0].Count; i++)
            {
                // Maak eerste een listview onderdeel (item) aan en vul deze met de voornaam en achternaam.
                ListViewItem newItem = new ListViewItem(new string[]
                {
                    alleInfo[0][i],    // toevoegen van de apparaatnaam
                    alleInfo[1][i],     // toevoegen van de uitleen status
                    alleInfo[2][i]     // toevoegen van de uitlener
                    alleInfo[3][i]     // toevoegen van eventuele opmerkingen
                });

                // nu we een onderdeel hebben aangemaakt, voeg nu het onderdeel toe aan de bestaande lijst.
                Lijst.Items.Add(newItem);
            }


        }

        private void terugg_Click(object sender, EventArgs e)
        {
            Beginpagina beginpagina = new Beginpagina(); //Maakt een nieuw exemplaar van Form2
            this.Hide(); //Hiermee wordt het oude venster verborgen 
            beginpagina.ShowDialog(); //Hiermee laat je het opgevraagde venster zien 
            this.Close(); //Hiermee wordt het oude venster gesloten
        }
    }
}
