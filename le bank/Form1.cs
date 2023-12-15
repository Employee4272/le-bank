using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace le_bank
{
    public partial class Form1 : Form
    {
        int result;
        int stan_a;
        int stan_b;
        int stan_c;
        public Form1()
        {
            InitializeComponent();
        }
        public int modyfikant()
        {
            Random rnd = new Random();
            result = Convert.ToInt32(Main.Text);
            int a = result;
            if (by10.Checked)
            {
                a *=10;
            }
            if(by100.Checked)
            {
                a*=100;
            }
            if (div10.Checked)
            {
                a /= 10;
            }
            if (div100.Checked)
            {
                a/=100;
            }
            if (plusRandom.Checked)
            {
                a = a + rnd.Next(1, 100);
            }
            if (minusRandom.Checked)
            {
                a = a - rnd.Next(1, 100);
            }
            return a;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            stan_c -= modyfikant();
            d_bank.Text = stan_c.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            stan_c += modyfikant();
            d_bank.Text = stan_c.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stan_b -= modyfikant();
            i_bank.Text = stan_b.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stan_b += modyfikant();
            i_bank.Text = stan_b.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stan_a -= modyfikant();
            a_bank.Text = stan_a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stan_a += modyfikant();
            a_bank.Text = stan_a.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
