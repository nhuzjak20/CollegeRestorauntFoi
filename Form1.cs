using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeRestraunt.classes;

namespace CollegeRestraunt
{
    public partial class Form1 : Form
    {
        private int UnesenStudent;
        DBclass Klasa;
        
        public Form1()
        {
            Klasa = new DBclass();
            InitializeComponent();
            UnesenStudent = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IzlazGumb_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void RegistracijaStudenta_Click(object sender, EventArgs e)
        {
            RegistrirajStudenta obrazac = new RegistrirajStudenta(Klasa);
            obrazac.ShowDialog();
            Console.WriteLine("Radi gumb");
        }

        private void RegistracijaProizvoda_Click(object sender, EventArgs e)
        {
            //RegistracijaProizvoda obrazac = new RegistracijaProizvoda();
            //obrazac.ShowDialog();
           
        }
    }
}
