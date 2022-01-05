using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BPAcc
{
    public partial class Form2 : Form
    {
        public int brojRacuna = 0;
        public int sifra = 0;
        public int zadnjiBroj = 0;
        public int pomoc = 0;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(3);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(3);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(1);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(2);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(2);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(4);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(4);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(5);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(5);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(6);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(6);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(7);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(7);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(8);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(8);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(9);
                }
            }
            else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(9);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                if (sifra < 10000)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(0);
                }
            } else
            {
                if (sifra < 10000)
                {
                    textBox2.Text = textBox2.Text + Convert.ToString(0);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                textBox1.Text = "";
            } else
            {
                textBox2.Text = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
        }
    }
}
