using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButtonKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonAvion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAutobus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonVlastiti_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rezerviraj_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.AppendText("Odabrali ste prijevoz: " + "\r\n");

            if(radioButtonAvion.Checked)
            {
                textBox1.AppendText("Avionom ");
            }
            if (radioButtonAutobus.Checked)
            {
                textBox1.AppendText("Autobusom ");
            }
            if (radioButtonVlastiti.Checked)
            {
                textBox1.AppendText("Vlastitim prijevozom ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
