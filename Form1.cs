using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButceHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KİRA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HESAPLA_Click(object sender, EventArgs e)
        {
            int maas = Convert.ToInt32(textBox1.Text);
            int kira = Convert.ToInt32(textBox2.Text);
            int taksit = Convert.ToInt32(textBox3.Text);
            int kredikartları = Convert.ToInt32(textBox4.Text);
            int faturalar = Convert.ToInt32(textBox5.Text);

            int bütçe = (maas - (kira + taksit + kredikartları + faturalar));

            textBox6.Text = Convert.ToString(bütçe);

           if (bütçe<=0)
            {
                textBox7.Text = "Durumunuz kritik!";
            }
            else if(bütçe>=0)
            {
                textBox7.Text = "Tebrikler! Bu ay bütçeniz iyi durumda";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
