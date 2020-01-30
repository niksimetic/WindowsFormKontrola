using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikSimetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chbSakrijNarudbu.Checked)
            {

            }
            else
            {


                if (chbDorucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Dorucak.");
                }
                if (chbRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Rucak.");
                }
                if (chbVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabarali ste Veceru.");
                }
            }
        }
        private void chbSakrijNarudbu_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbSakrijNarudbu.Checked)
            {

                if (chbDorucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Dorucak.");
                }
                if (chbRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Rucak.");
                }
                if (chbVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabarali ste Veceru.");
                }

            }
            else
            {
                txtPrikaz.Clear();
            }
        }
    }



}