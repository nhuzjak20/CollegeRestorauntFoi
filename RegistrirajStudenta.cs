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
    public partial class RegistrirajStudenta : Form
    {
        DBclass Klasa;
        public RegistrirajStudenta(DBclass klasa)
        {
            InitializeComponent();
            Klasa = klasa;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Unesi Cijelovite Podatke","Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Klasa.InsertStudent(textBox1.Text, textBox2.Text);
                StudentClass noviStudent = new StudentClass(textBox1.Text, textBox2.Text);
                Klasa.students.Add(noviStudent);
                this.Close();
               
       
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
