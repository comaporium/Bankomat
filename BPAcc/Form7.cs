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
    public partial class Form7 : Form
    {
        public static string brojRacunaTrenutnogKorisnika = "";
        public static string trenutnaSumaNovca = "";
        public static string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bankomat;Integrated Security=True";
        public static int novaSumaNovcaPosiljaoca;
        public static int novaSumaNovcaPrimaoca;

        public Form7()
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
            novaSumaNovcaPosiljaoca = int.Parse(trenutnaSumaNovca);

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

        private void button2_Click(object sender, EventArgs e)
        {
            var Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Form6 = new Form6();
            Form6.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string brojRacunaZeljenogKorisnika = textBox1.Text;
                int upisanaKolicinaZeljenogNovca = int.Parse(textBox2.Text);
                string sumaNovcaPrimaoca;
                if (novaSumaNovcaPosiljaoca >= upisanaKolicinaZeljenogNovca)
                {
                    novaSumaNovcaPosiljaoca = novaSumaNovcaPosiljaoca - upisanaKolicinaZeljenogNovca;
                    string query1 = "SELECT BrojRacuna, StanjeRacuna FROM Racun WHERE BrojRacuna = '" + brojRacunaZeljenogKorisnika + "'"; 
                    SqlConnection konekcija = new SqlConnection(conString);
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand(query1, konekcija);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Broj racuna je nepostojeci.");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        reader.Close();
                        //konekcija.Close();
                    }
                    else
                    {
                        brojRacunaZeljenogKorisnika = reader[0].ToString();
                        sumaNovcaPrimaoca = reader[1].ToString();
                        novaSumaNovcaPrimaoca = int.Parse(sumaNovcaPrimaoca) + upisanaKolicinaZeljenogNovca;
                        MessageBox.Show("Uspješno ste uplatili " + upisanaKolicinaZeljenogNovca + " KM na račun " + brojRacunaZeljenogKorisnika);
                        reader.Close();
                        konekcija.Close();
                        string query2 = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovcaPosiljaoca + "' WHERE BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "'";
                        string query3 = "INSERT INTO Trans(BrojRacunaPosiljaoca, BrojRacunaPrimaoca, VrstaUslugeID, Vrijednost, BankomatID) VALUES("+ brojRacunaTrenutnogKorisnika + "," + brojRacunaZeljenogKorisnika + "," + 3 + "," + upisanaKolicinaZeljenogNovca + "," + 1 + ")";
                        string query4 = "UPDATE Racun SET StanjeRacuna = '" + novaSumaNovcaPrimaoca + "' WHERE BrojRacuna = '" + brojRacunaZeljenogKorisnika + "'";
                        SqlConnection konekcija2 = new SqlConnection(conString);
                        konekcija2.Open();
                        SqlCommand cmd2 = new SqlCommand(query2, konekcija2);
                        cmd2.ExecuteNonQuery();
                        SqlCommand cmd3 = new SqlCommand(query3, konekcija2);
                        cmd3.ExecuteNonQuery();
                        SqlCommand cmd4 = new SqlCommand(query4, konekcija2);
                        cmd4.ExecuteNonQuery();
                        konekcija2.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
