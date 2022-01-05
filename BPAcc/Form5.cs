using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPAcc
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button10.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            button8.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button10.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            button8.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Form7 = new Form7();
            Form7.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Form8 = new Form8();
            Form8.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Form9 = new Form9();
            Form9.Show();
            this.Hide();
        }
    }
}
