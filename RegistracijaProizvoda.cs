using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeRestraunt.classes;
using System.Windows.Forms;

namespace CollegeRestraunt
{
    public partial class RegistracijaProizvoda : Form
    {
        DBclass Klasa;
        public RegistracijaProizvoda(DBclass klasa)
        {
            InitializeComponent();
            Klasa = klasa;
            dataGridView1.Columns.Add("kod", "Kod Artikla");
            dataGridView1.Columns.Add("naziv", "Naziv Artikla");
            dataGridView1.Columns.Add("cijena", "Cijena Artikla");
            foreach (JeloClass jelo in Klasa.jela)
            {
                dataGridView1.Rows.Add(jelo.Kod, jelo.Naziv, jelo.Cijena);
            }
        }
        
       
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Unesi Cijelovite Podatke", "Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (Klasa.RegistracijaProizvoda(textBox1.Text, textBox2.Text, textBox3.Text) == 1)
                {
                    MessageBox.Show("Proizvod je unesen", "Operacija je uspješna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateJela(object sender, DataGridViewCellEventArgs e)
        {
            string KodProizvoda = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            button3.Enabled = true;
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
