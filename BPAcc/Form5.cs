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
    public partial class Form5 : Form
    {
        public static string brojRacunaTrenutnogKorisnika = "";
        public static string trenutnaSumaNovca = "";
        public static string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bankomat;Integrated Security=True";
        public static int novaSumaNovca;

        public Form5()
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

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (novaSumaNovca >= 20)
                {
                    novaSumaNovca = novaSumaNovca - 20;
                    string query = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovca + "' WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
                    string query2 = "INSERT INTO Transakcija(BrojRacuna, VrstaUslugeID, Vrijednost, BankomatID) VALUES(" + brojRacunaTrenutnogKorisnika + ", " + 1 + ", " + 20 + ", " + 1 + ")";
                    SqlConnection konekcija = new SqlConnection(conString);
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, konekcija);
                    cmd2.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Uspješno ste podigli 20 KM sa vašeg računa.");
                }
                else
                {
                    MessageBox.Show("Nedovoljno sredstava za traženu uslugu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (novaSumaNovca >= 50)
                {
                    novaSumaNovca = novaSumaNovca - 50;
                    string query = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovca + "' WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
                    string query2 = "INSERT INTO Transakcija(BrojRacuna, VrstaUslugeID, Vrijednost, BankomatID) VALUES(" + brojRacunaTrenutnogKorisnika + ", " + 1 + ", " + 50 + ", " + 1 + ")";
                    SqlConnection konekcija = new SqlConnection(conString);
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, konekcija);
                    cmd2.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Uspješno ste podigli 50 KM sa vašeg računa.");
                }
                else
                {
                    MessageBox.Show("Nedovoljno sredstava za traženu uslugu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (novaSumaNovca >= 100)
                {
                    novaSumaNovca = novaSumaNovca - 100;
                    string query = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovca + "' WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
                    string query2 = "INSERT INTO Transakcija(BrojRacuna, VrstaUslugeID, Vrijednost, BankomatID) VALUES(" + brojRacunaTrenutnogKorisnika + ", " + 1 + ", " + 100 + ", " + 1 + ")";
                    SqlConnection konekcija = new SqlConnection(conString);
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, konekcija);
                    cmd2.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Uspješno ste podigli 100 KM sa vašeg računa.");
                }
                else
                {
                    MessageBox.Show("Nedovoljno sredstava za traženu uslugu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (novaSumaNovca >= 200)
                {
                    novaSumaNovca = novaSumaNovca - 200;
                    string query = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovca + "' WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
                    string query2 = "INSERT INTO Transakcija(BrojRacuna, VrstaUslugeID, Vrijednost, BankomatID) VALUES(" + brojRacunaTrenutnogKorisnika + ", " + 1 + ", " + 200 + ", " + 1 + ")";
                    SqlConnection konekcija = new SqlConnection(conString);
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, konekcija);
                    cmd2.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Uspješno ste podigli 200 KM sa vašeg računa.");
                }
                else
                {
                    MessageBox.Show("Nedovoljno sredstava za traženu uslugu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int upisanaKolicinaZeljenogNovca = int.Parse(textBox1.Text);
                if (upisanaKolicinaZeljenogNovca % 10 == 0) {
                    if (novaSumaNovca >= upisanaKolicinaZeljenogNovca)
                    {
                        novaSumaNovca = novaSumaNovca - upisanaKolicinaZeljenogNovca;
                        string query = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovca + "' WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
                        string query2 = "INSERT INTO Transakcija(BrojRacuna, VrstaUslugeID, Vrijednost, BankomatID) VALUES(" + brojRacunaTrenutnogKorisnika + ", " + 1 + ", " + upisanaKolicinaZeljenogNovca + ", " + 1 + ")";
                        SqlConnection konekcija = new SqlConnection(conString);
                        konekcija.Open();
                        SqlCommand cmd = new SqlCommand(query, konekcija);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd2 = new SqlCommand(query2, konekcija);
                        cmd2.ExecuteNonQuery();
                        konekcija.Close();
                        MessageBox.Show("Uspješno ste podigli " + upisanaKolicinaZeljenogNovca + " KM sa vašeg računa.");
                    }
                    else
                    {
                        MessageBox.Show("Nedovoljno sredstava za traženu uslugu.");
                    }
                } else
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
