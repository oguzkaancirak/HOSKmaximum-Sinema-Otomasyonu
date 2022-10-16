using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HOSKmaximum
{
    public partial class film_secim : Form
    {
        public film_secim()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=cinema.accdb");

        void baglantiKur()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void button_FILMEKLE_Click(object sender, EventArgs e)
        {
            film_ekle frm = new film_ekle();
            frm.Show();
            this.Hide();
        }

        void bilgiAl(string sql, ComboBox cmb)
        {
            cmb.Items.Clear();
            baglantiKur();
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmb.Items.Add(oku[1].ToString());
            }
            connection.Close();
        }

        private void comboBox_film_select_Click(object sender, EventArgs e)
        {
            bilgiAl("SELECT * FROM filmler", comboBox_film_select);
        }

        private void comboBox_salon_select_Click(object sender, EventArgs e)
        {
            bilgiAl("SELECT * FROM salonlar", comboBox_salon_select);
        }

        private void button_REZERVASYON_Click(object sender, EventArgs e)
        {
            if (comboBox_salon_select.SelectedIndex != -1 && comboBox_film_select.SelectedIndex != -1 && comboBox_seans_select.SelectedIndex != -1)
            {
                film_rezervasyonu rezerve = new film_rezervasyonu();
                rezerve.salon_Adi = comboBox_salon_select.Text;
                rezerve.film_Adi = comboBox_film_select.Text;
                rezerve.seans = comboBox_seans_select.Text;
                rezerve.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Film Bilgilerini Eksiksiz Doldurunuz.");
            }           
        }
    }
}
