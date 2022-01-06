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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string brojRacuna;
        public static string sifra;
        public static string stanje;
        public string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bankomat;Integrated Security=True";
        public static string ID;
        public static string ime;


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
            string brRacuna = textBox1.Text;
            string pin = textBox2.Text;
            /*string query = "SELECT r.BrojRacuna, k.korisnikID, r.Pin, k.Ime" +
               " FROM racun r, korisnik k WHERE r.BrojRacuna ='" + brRacuna + "' AND k.KorisnikID = r.KorisnikID";*/
            string query = "SELECT Racun.BrojRacuna, Racun.KorisnikID, Racun.Pin, Korisnik.Ime FROM Racun INNER JOIN Korisnik ON" +
                " Racun.KorisnikID = Korisnik.KorisnikID WHERE Racun.BrojRacuna = '"+ brRacuna +"'";
            try
            {
                SqlConnection konekcija = new SqlConnection(conString);
                konekcija.Open();
                SqlCommand cmd = new SqlCommand(query, konekcija);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    errorProvider1.SetError(textBox1, "Nepostojeći račun!");
                }
                else
                {
                    brojRacuna = reader[0].ToString();
                    ID = reader[1].ToString();
                    sifra = reader[2].ToString();
                    ime = reader[3].ToString();
                    if (pin == sifra)
                    {
                        MessageBox.Show("Dobrodošli, " + ime + "!");
                        var Form3 = new Form3();
                        Form3.Show();
                        this.Hide();
                    } else
                    {
                        errorProvider1.SetError(textBox2, "Pogrešan pin!");
                    }
                }
                reader.Close();
                konekcija.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
               textBox1.Text = textBox1.Text + Convert.ToString(3);

            }
            else
            {
               textBox2.Text = textBox2.Text + Convert.ToString(3);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
               textBox1.Text = textBox1.Text + Convert.ToString(1);
            }
            else
            {
               textBox2.Text = textBox2.Text + Convert.ToString(1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
               textBox1.Text = textBox1.Text + Convert.ToString(2);
            }
            else
            {
               textBox2.Text = textBox2.Text + Convert.ToString(2);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
               textBox1.Text = textBox1.Text + Convert.ToString(4);
            }
            else
            {
               textBox2.Text = textBox2.Text + Convert.ToString(4);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
               textBox1.Text = textBox1.Text + Convert.ToString(5);
            }
            else
            {
               textBox2.Text = textBox2.Text + Convert.ToString(5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
               textBox1.Text = textBox1.Text + Convert.ToString(6);
            }
            else
            {
               textBox2.Text = textBox2.Text + Convert.ToString(6);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
               textBox1.Text = textBox1.Text + Convert.ToString(7);
            }
            else
            {
               textBox2.Text = textBox2.Text + Convert.ToString(7);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(8);
            }
            else
            {
                textBox2.Text = textBox2.Text + Convert.ToString(8);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox2.Visible == false)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(9);
            }
            else
            {
                textBox2.Text = textBox2.Text + Convert.ToString(9);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(0);
            } else
            {
                textBox2.Text = textBox2.Text + Convert.ToString(0);
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
                textBox1.Text = "";
                textBox2.Visible = false;
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
