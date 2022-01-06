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
    public partial class Form3 : Form
    {
        public static string imeTrenutnogKorisnika = "";
        public Form3()
        {
            InitializeComponent();

            imeTrenutnogKorisnika = Form2.ime;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Form5 = new Form5();
            Form5.Show();
            this.Hide();
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
