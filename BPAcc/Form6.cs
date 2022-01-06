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

    public partial class Form6 : Form
    {

        public static string brojRacunaTrenutnogKorisnika = "";
        public static string trenutnaSumaNovca = "";
        public static string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bankomat;Integrated Security=True";
        public static int novaSumaNovca;

        public Form6()
        {
            InitializeComponent();
            brojRacunaTrenutnogKorisnika = Form2.brojRacuna;
            string query = "SELECT StanjeRacuna FROM Racun WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
            SqlConnection konekcija = new SqlConnection(conString);
            konekcija.Open();
            SqlCommand cmd = new SqlCommand(query, konekcija);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            trenutnaSumaNovca = reader[0].ToString();
            reader.Close();
            konekcija.Close();
            novaSumaNovca = int.Parse(trenutnaSumaNovca);
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

        private void button1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int upisanaKolicinaZeljenogNovca = int.Parse(textBox1.Text);
                if (upisanaKolicinaZeljenogNovca % 10 == 0)
                {
                    novaSumaNovca = novaSumaNovca + upisanaKolicinaZeljenogNovca;
                    string query = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovca + "' WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
                    string query2 = "INSERT INTO Transakcija(BrojRacuna, VrstaUslugeID, Vrijednost, BankomatID) VALUES(" + brojRacunaTrenutnogKorisnika + ", " + 2 + ", " + upisanaKolicinaZeljenogNovca + ", " + 1 + ")";
                    SqlConnection konekcija = new SqlConnection(conString);
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, konekcija);
                    cmd2.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Uspješno ste uplatili " + upisanaKolicinaZeljenogNovca + " KM na vaš račun.");
                }
                else
                {
                    MessageBox.Show("Suma nije validna.");
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

