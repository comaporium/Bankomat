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
    public partial class Form8 : Form
    {
        public static string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bankomat;Integrated Security=True";
        public static int sviRedoviTabeleTransakcija;
        public static string brojRacunaTrenutnogKorisnika;
        public Form8()
        {
            InitializeComponent();
            brojRacunaTrenutnogKorisnika = Form2.brojRacuna;
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                string query = "SELECT Transakcija.Vrijednost, Transakcija.DatumIVrijeme, Grad.Ime_grada " +
                        "FROM Transakcija JOIN Bankomat ON Transakcija.BankomatID = Bankomat.BankomatID " +
                        "JOIN Grad " +
                        "ON Bankomat.GradID = Grad.GradID " +
                        "WHERE Transakcija.BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "' AND Transakcija.VrstaUslugeID = 1";

                SqlConnection konekcija = new SqlConnection(conString);
                konekcija.Open();
                SqlCommand cmd = new SqlCommand(query, konekcija);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    reader.Read();
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = reader[0].ToString();
                    newRow.Cells[1].Value = reader[1].ToString();
                    newRow.Cells[2].Value = reader[2].ToString();
                    dataGridView1.Rows.Add(newRow);
                }
                reader.Close();
                konekcija.Close();
            }
            catch { }

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

        private void button4_Click(object sender, EventArgs e)
        {
            var Form6 = new Form6();
            Form6.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            var Form9 = new Form9();
            Form9.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                string query = "SELECT Transakcija.Vrijednost, Transakcija.DatumIVrijeme, Grad.Ime_grada " +
                        "FROM Transakcija JOIN Bankomat ON Transakcija.BankomatID = Bankomat.BankomatID " +
                        "JOIN Grad " +
                        "ON Bankomat.GradID = Grad.GradID " +
                        "WHERE Transakcija.BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "' AND Transakcija.VrstaUslugeID = 2";

                SqlConnection konekcija = new SqlConnection(conString);
                konekcija.Open();
                SqlCommand cmd = new SqlCommand(query, konekcija);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    reader.Read();
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = reader[0].ToString();
                    newRow.Cells[1].Value = reader[1].ToString();
                    newRow.Cells[2].Value = reader[2].ToString();
                    dataGridView1.Rows.Add(newRow);
                }
                reader.Close();
                konekcija.Close();
            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                string query = "SELECT Transakcija.Vrijednost, Transakcija.DatumIVrijeme, Grad.Ime_grada " +
                        "FROM Transakcija JOIN Bankomat ON Transakcija.BankomatID = Bankomat.BankomatID " +
                        "JOIN Grad " +
                        "ON Bankomat.GradID = Grad.GradID " +
                        "WHERE Transakcija.BrojRacuna = '" + brojRacunaTrenutnogKorisnika + "' AND Transakcija.VrstaUslugeID = 1";

                SqlConnection konekcija = new SqlConnection(conString);
                konekcija.Open();
                SqlCommand cmd = new SqlCommand(query, konekcija);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    reader.Read();
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = reader[0].ToString();
                    newRow.Cells[1].Value = reader[1].ToString();
                    newRow.Cells[2].Value = reader[2].ToString();
                    dataGridView1.Rows.Add(newRow);
                }
                reader.Close();
                konekcija.Close();
            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                string query = "SELECT Trans.BrojRacunaPosiljaoca, Trans.BrojRacunaPrimaoca, Trans.Vrijednost, Trans.DatumIVrijeme, Grad.Ime_grada "+
                    "FROM Trans "+
                    "JOIN Bankomat "+
                    "ON Trans.BankomatID = Bankomat.BankomatID "+
                    "JOIN Grad "+
                    "ON Bankomat.GradID = Grad.GradID "+
                    "WHERE Trans.BrojRacunaPosiljaoca = '"+ brojRacunaTrenutnogKorisnika +"' OR Trans.BrojRacunaPrimaoca = '"+ brojRacunaTrenutnogKorisnika +"'";

                SqlConnection konekcija = new SqlConnection(conString);
                konekcija.Open();
                SqlCommand cmd = new SqlCommand(query, konekcija);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    reader.Read();
                    DataGridViewRow newRow2 = new DataGridViewRow();
                    newRow2.CreateCells(dataGridView2);
                    String korisnikKaoPosiljaoc = reader[0].ToString();

                    if (korisnikKaoPosiljaoc == brojRacunaTrenutnogKorisnika)
                    {
                        newRow2.Cells[0].Value = "Vi";
                    }
                    else
                    {
                        newRow2.Cells[0].Value = korisnikKaoPosiljaoc;
                    }
                    String korisnikKaoPrimaoc = reader[1].ToString();
                    if (korisnikKaoPrimaoc == brojRacunaTrenutnogKorisnika)
                    {
                        newRow2.Cells[1].Value = "Vi";
                    }
                    else
                    {
                        newRow2.Cells[1].Value = korisnikKaoPrimaoc;
                    }
                    newRow2.Cells[2].Value = reader[2].ToString();
                    newRow2.Cells[3].Value = reader[3].ToString();
                    newRow2.Cells[4].Value = reader[4].ToString();
                    dataGridView2.Rows.Add(newRow2);
                }
                reader.Close();
                konekcija.Close();
            }
            catch{ }
        }
    }
}
