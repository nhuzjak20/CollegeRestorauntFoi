using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRestraunt
{
    public partial class RegistracijaProizvoda : Form
    {
        public RegistracijaProizvoda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Unesi Cijelovite Podatke", "Ne radi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {

            }
        }
    }
}
