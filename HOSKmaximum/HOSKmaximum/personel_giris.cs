using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace HOSKmaximum
{
    public partial class personel_giris : Form
    {
        public personel_giris()
        {
            InitializeComponent();
        }

        OleDbConnection connect;
        OleDbCommand command;
        OleDbDataReader datareader;

        private void button_giris_Click(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=cinema.accdb");
            command = new OleDbCommand();
            connect.Open();
            command.Connection = connect;
            command.CommandText = "SELECT * FROM personel_giris where Personel_id='" + textBox_kullanici.Text + "' AND Personel_sifre='" + textBox_sifre.Text + "'";
            datareader = command.ExecuteReader();
            if (datareader.Read())
            {
                film_secim frm = new film_secim();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Yanlış");
            }
            connect.Close();
        }

        private void label_kayıt_olusturma_Click(object sender, EventArgs e)
        {
            string sifre = Interaction.InputBox("\n\nŞİFREYİ GİRİNİZ", "", "");
            if (sifre == "hosk")
            {
                personel_ekle ekle = new personel_ekle();
                ekle.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("YANLIŞ ŞİFRE\nLÜTFEN TEKRAR DENEYİNİZ...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personel_giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gerçekten programı kapatmak istiyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void button_bilgi_unuttum_Click(object sender, EventArgs e)
        {
            sifreUnuttum frm = new sifreUnuttum();
            frm.Show();
            this.Hide();
        }
    }
}
