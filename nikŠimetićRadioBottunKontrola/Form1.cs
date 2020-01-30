using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikŠimetićRadioBottunKontrola
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

        private void radioButtonAutobus_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (radioButtonAvion.Checked)
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            else if (radioButtonAutobus.Checked)
                textBox1.Text = "Odabrali ste prijevoz autobusom.";
            else if (radioButtonVlastiti.Checked)
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            else
            {
                // u slucaju da nista nije odabrano
                MessageBox.Show("Odaberite tip prijevoza.");
                return;
            }

        }
    }
}
