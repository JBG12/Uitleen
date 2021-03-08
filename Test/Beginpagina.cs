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

        
        public Beginpagina()
        {
            InitializeComponent();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inleveren Inleveren = new inleveren(); //Maakt een nieuw exemplaar van Form2
           this.Hide(); //Hiermee wordt het oude venster verborgen 
            Inleveren.ShowDialog(); //Hiermee laat je het opgevraagde venster zien 
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
            Uitleen uitleen = new Uitleen(); //Maakt een nieuw exemplaar van Form2
            this.Hide(); //Hiermee wordt het oude venster verborgen 
            uitleen.ShowDialog(); //Hiermee laat je het opgevraagde venster zien 
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
