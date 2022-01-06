using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BPAcc
{
    public partial class Form4 : Form
    {
        public static string brojRacunaKorisnika = "";
        public static string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bankomat;Integrated Security=True";
        public static string stanjeRacuna;
        public Form4()
            {
                InitializeComponent();
                brojRacunaKorisnika = Form2.brojRacuna;

            string query = "SELECT StanjeRacuna FROM Racun INNER JOIN Korisnik ON" +
            " Racun.KorisnikID = Korisnik.KorisnikID WHERE Racun.BrojRacuna = '" + brojRacunaKorisnika + "'";
            try
            {
                SqlConnection konekcija = new SqlConnection(conString);
                konekcija.Open();
                SqlCommand cmd = new SqlCommand(query, konekcija);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                stanjeRacuna = reader[0].ToString();
                reader.Close();
                konekcija.Close();
                textBox1.Text = stanjeRacuna.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                var Form3 = new Form3();
                Form3.Show();
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

            private void pictureBox2_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

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

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }
   }
}
