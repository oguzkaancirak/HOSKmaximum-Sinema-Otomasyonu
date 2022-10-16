using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace HOSKmaximum
{
    public partial class sifreUnuttum : Form
    {
        public sifreUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient sc = new SmtpClient();
                sc.Credentials = new NetworkCredential("oguzkaancirak@gmail.com", "kaanbaba2000");
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                mail.To.Add("oguzkaancirak@gmail.com");
                mail.From = new MailAddress("oguzkaancirak@gmail.com");
                mail.Subject = "Şifremi Unuttum";
                mail.Body = "ŞİFREMİ UNUTTUM\n" + richTextBox_mesaj.Text;
                sc.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("E-posta Gönderildi...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_konu.Clear();
            richTextBox_mesaj.Clear();
        }

        private void sifreUnuttum_FormClosing(object sender, FormClosingEventArgs e)
        {
            personel_giris frm = new personel_giris();
            frm.Show();
            this.Hide();
        }
    }
}
