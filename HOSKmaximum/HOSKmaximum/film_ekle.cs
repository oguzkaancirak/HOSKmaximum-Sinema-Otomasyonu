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
    public partial class film_ekle : Form
    {
        public film_ekle()
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
            baglantiKur();
            string sorgu = "INSERT INTO filmler(film_ADI,yonetmen,film_TUR) VALUES('" + textbox_filmAdi.Text + "','" + textbox_Yonetmen.Text + "','" + textbox_TUR.Text + "')";
            OleDbCommand command = new OleDbCommand(sorgu, connection);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show(textbox_filmAdi.Text + " / " + textbox_Yonetmen.Text + " / " + textbox_TUR.Text + " filmi eklendi");
            textbox_filmAdi.Text = "";
            textbox_Yonetmen.Text = "";
            textbox_TUR.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            film_secim frm = new film_secim();
            frm.Show();
            this.Hide();
        }
    }
}
