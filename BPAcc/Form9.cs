﻿using System;
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
    public partial class Form9 : Form
    {

        public static string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bankomat;Integrated Security=True";
        public static string idTrenutnogKorisnika;
        public static string brojRacunaKorisnika;
        public Form9()
        {
            InitializeComponent();
            idTrenutnogKorisnika = Form2.ID;
            brojRacunaKorisnika = Form2.brojRacuna;
            string query = "SELECT Ime, Prezime, AdresaStanovanja, KontaktTelefon FROM Korisnik WHERE KorisnikID = '" + idTrenutnogKorisnika + "'";
            SqlConnection konekcija = new SqlConnection(conString);
            konekcija.Open();
            SqlCommand cmd = new SqlCommand(query, konekcija);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            label1.Text = reader[0].ToString();
            label2.Text = reader[1].ToString();
            label3.Text = reader[2].ToString();
            label4.Text = reader[3].ToString();
            label5.Text = brojRacunaKorisnika;
            reader.Close();
            konekcija.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Form8 = new Form8();
            Form8.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        }
    }

