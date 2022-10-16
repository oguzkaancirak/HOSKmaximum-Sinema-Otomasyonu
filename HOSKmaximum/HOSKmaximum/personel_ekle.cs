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
    public partial class personel_ekle : Form
    {
        public personel_ekle()
        {
            InitializeComponent();
        }

        //VERİ TABANINI BAĞLAMA
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=cinema.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataTable table = new DataTable();

        public void listele()
        {
            table.Clear(); //Daha önceki tablo içeriğini temizler
            connection.Open(); //Bağlantıyı Açar.
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from personel_giris", connection); //adöpter ile accessdeki verileri ulaşır
            adtr.Fill(table); //adaptördeki verileri table tablosuna atar-basar.
            dataGridView1.DataSource = table; //datagride table tablosundaki verileri atar.
            adtr.Dispose(); //adaptör nesnesinin bağlatısını seçer.
            connection.Close(); //Bağlantı Kesilir.
        }

        private void button_EKLE_Click(object sender, EventArgs e)
        {
            listele();
            try
            {
                //Insert into TABLOADI(ALAN) values (DEGERLER)
                string sorgu = "Insert into personel_giris (Personel_no,Personel_id,Personel_sifre) values (@Personel_no,@Personel_id,@Personel_sifre)";
                //EKLEME KOMUTU
                command = new OleDbCommand(sorgu, connection);
                //KOMUTU ALIYOR
                command.Parameters.AddWithValue("@Personel_no", txt_NO_EKLE.Text);
                command.Parameters.AddWithValue("@Personel_id", txt_PID_EKLE.Text);
                command.Parameters.AddWithValue("@Personel_sifre", txt_SIFRE_EKLE.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                listele();
                txt_NO_EKLE.Text = "";
                txt_PID_EKLE.Text = "";
                txt_SIFRE_EKLE.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Numaraya Ait Kişi Bulunmaktadır!!");
                connection.Close();
                table.Clear();
                listele();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.Yes)
                {
                    command = new OleDbCommand("delete from personel_giris where Personel_no=@Personel_no", connection);
                    command.Parameters.AddWithValue("@Personel_no", dataGridView1.CurrentRow.Cells[0].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    listele();
                    MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!", "Uyarı");
            } 
        }

        private void button_geridon_Click(object sender, EventArgs e)
        {
            personel_giris gir = new personel_giris();
            gir.Show();
            this.Hide();
        }

        private void personel_ekle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button_UPDATE_Click(object sender, EventArgs e)
        {
            string sorgu = "Update personel_giris Set Personel_no=@Personel_no,Personel_id=@Personel_id,Personel_sifre=@Personel_sifre Where Personel_no=@Personel_no";
            command = new OleDbCommand(sorgu, connection);
            command.Parameters.AddWithValue("@Personel_no", txt_NO_UPDATE.Text);
            command.Parameters.AddWithValue("@Personel_id", txt_PID_UPDATE.Text);
            command.Parameters.AddWithValue("@Personel_sifre", txt_SIFRE_UPDATE.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_NO_UPDATE.Text = row.Cells["Personel_no"].Value.ToString();
                txt_PID_UPDATE.Text = row.Cells["Personel_id"].Value.ToString();
                txt_SIFRE_UPDATE.Text = row.Cells["Personel_sifre"].Value.ToString();
            }
        }

        private void personel_ekle_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
