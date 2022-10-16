using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace HOSKmaximum
{
    public partial class film_rezervasyonu : Form
    {
        public film_rezervasyonu()
        {
            InitializeComponent();
        }

        public string film_Adi = "";
        public string salon_Adi = "";
        public string seans = "";
        ArrayList koltuklar = new ArrayList();
        ArrayList iptalKoltuk = new ArrayList();
        int filmID1 = 0;
        int salonID1 = 0;

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=cinema.accdb");

        void baglantiKur()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        void biletAyir()
        {
            baglantiKur();
            string ucret = "";
            if (radioButton_Ogrenci.Checked) ucret = "6";
            else ucret = "10";

            for (int i = 0; i < koltuklar.Count; i++)
            {
                string sql = "INSERT INTO satis(film_ID,salon_ID,tarih,seans,satis_ADI,satis_SOYAD,koltuk_NO,ucret) VALUES (" + filmID1 + "," + salonID1 + ",'" + lblTarih.Text + "','" + seans + "','" + textbox_Adi.Text + "','" + textbox_Soyadi.Text + "'," + Convert.ToInt32(koltuklar[i]) + ",'" + ucret + "')";
                OleDbCommand command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();
                this.Controls.Find("btn" + koltuklar[i].ToString(), true)[0].BackColor = Color.Red;
            }

            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Chartreuse) // yeşil
            {
                ((Button)sender).BackColor = Color.Orange;
                if (!koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Add(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else if (((Button)sender).BackColor == Color.Orange) // turuncu
            {
                ((Button)sender).BackColor = Color.Chartreuse;
                if (koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Remove(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else // kırmızı
            {
                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {
                    iptalKoltuk.Add(((Button)sender).Text);
                }
                else
                {
                    iptalKoltuk.Remove(((Button)sender).Text);
                }

                string koltuk = "";
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    koltuk += iptalKoltuk[i].ToString() + ",";
                }
                if (iptalKoltuk.Count >= 1)
                {
                    koltuk = koltuk.Remove(koltuk.Length - 1, 1);
                }
                textbox_KoltukIptal.Text = koltuk;
            }
        }

        void koltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                koltuk += koltuklar[i].ToString() + ",";
            }
            if (koltuklar.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);
            }
            textbox_KoltukNo.Text = koltuk;
        }

        void LogAl()
        {
            baglantiKur();
            string sorgu = "SELECT * FROM satis WHERE film_ID=" + filmID1 + " AND salon_ID=" + salonID1 + " AND seans='" + seans + "'";
            OleDbCommand cmd = new OleDbCommand(sorgu, connection);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                string koltuk_No = oku[7].ToString();
                this.Controls.Find("btn" + koltuk_No, true)[0].BackColor = Color.Red;
            }
            connection.Close();
        }

        string araGetir(string sql)
        {
            baglantiKur();
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            OleDbDataReader oku = cmd.ExecuteReader();
            oku.Read();
            string deger = oku[0].ToString();
            connection.Close();
            return deger;
        }

        private void film_rezervasyonu_Load(object sender, EventArgs e)
        {
            label_FilmAdi.Text = film_Adi;
            label_SalonSeans.Text = salon_Adi + " / " + seans;
            timer1.Enabled = true;
            filmID1 = Convert.ToInt32(araGetir("SELECT * FROM filmler WHERE film_ADI='" + film_Adi + "'"));
            salonID1 = Convert.ToInt32(araGetir("SELECT * FROM salonlar WHERE salon_ADI='" + salon_Adi + "'"));
            LogAl();
        }

        private void btnBilet_iptal_Click(object sender, EventArgs e)
        {
            if (textbox_KoltukIptal.Text != "")
            {
                baglantiKur();
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    string sql = "DELETE FROM satis WHERE koltuk_NO=" + Convert.ToInt32(iptalKoltuk[i]);
                    OleDbCommand cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    this.Controls.Find("btn" + iptalKoltuk[i].ToString(), true)[0].BackColor = Color.Chartreuse;
                }

                connection.Close();
                iptalKoltuk.Clear();
                MessageBox.Show(textbox_KoltukNo.Text + " Koltuk Numaraları Bileti İptal Edilmiştir.");
                textbox_KoltukIptal.Text = "";
                textbox_Adi.Text = "";
                textbox_Soyadi.Text = "";
            }
            else
            {
                MessageBox.Show("Koltuk Numarasını Seçmediniz.");
            }
        }

        private void btnBiletAyir_Click(object sender, EventArgs e)
        {
            if (textbox_KoltukNo.Text != "")
            {
                if (textbox_KoltukNo.Text != "" && textbox_Adi.Text != "" && textbox_Soyadi.Text != "")
                {
                    biletAyir();
                    MessageBox.Show(textbox_Adi.Text + " " + textbox_Soyadi.Text + " Bilgili Kişinin " + textbox_KoltukNo.Text + " No'lu Koltukları Ayrılmıştır");
                    textbox_KoltukNo.Text = "";
                    textbox_Adi.Text = "";
                    textbox_Soyadi.Text = "";
                    koltuklar.Clear();
                }
                else
                {
                    MessageBox.Show("Tüm Bilgileri Eksiksiz Doldurmalısınız!!!");
                }
            }
            else
            {
                MessageBox.Show("Koltuk Numarasını Seçmediniz.", "DİKKAT");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            film_secim frm = new film_secim();
            frm.Show();
            this.Hide();
        }
    }
}
