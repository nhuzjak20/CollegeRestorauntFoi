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
        private string JmbagStudenta;
        public RegistrirajStudenta(DBclass klasa)
        {
            InitializeComponent();
            Klasa = klasa;
            dataGridView1.Columns.Add("ime", "Ime Studenta");
            dataGridView1.Columns.Add("jmbag", "JMBAG");
            foreach (StudentClass student in Klasa.students)
            {
                dataGridView1.Rows.Add(student.JMBAG, student.ImeIprezime);
            }
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
                MessageBox.Show("Unesen je student", "Radi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               
       
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Klasa.ObrisiStudenta(textBox2.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (StudentClass student in Klasa.students)
            {
                dataGridView1.Rows.Add(student.JMBAG, student.ImeIprezime);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            JmbagStudenta = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            button3.Enabled = true;
            button4.Enabled = true;
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Klasa.AzurirajStudenta(textBox1.Text, textBox2.Text, JmbagStudenta);
            dataGridView1.Rows.Clear();
            
            foreach (StudentClass student in Klasa.students)
            {
                dataGridView1.Rows.Add(student.JMBAG, student.ImeIprezime);
            }
            dataGridView1.Refresh();
        }
    }
}
