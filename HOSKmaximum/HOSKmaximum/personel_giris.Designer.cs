namespace HOSKmaximum
{
    partial class personel_giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_giris));
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_kullanici = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_giris = new System.Windows.Forms.Button();
            this.button_bilgi_unuttum = new System.Windows.Forms.Button();
            this.label_kayıt_olusturma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(82, 35);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(131, 20);
            this.textBox_sifre.TabIndex = 2;
            // 
            // textBox_kullanici
            // 
            this.textBox_kullanici.Location = new System.Drawing.Point(82, 6);
            this.textBox_kullanici.Name = "textBox_kullanici";
            this.textBox_kullanici.Size = new System.Drawing.Size(131, 20);
            this.textBox_kullanici.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // button_giris
            // 
            this.button_giris.Location = new System.Drawing.Point(117, 61);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(96, 23);
            this.button_giris.TabIndex = 4;
            this.button_giris.Text = "Giriş Yap";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // button_bilgi_unuttum
            // 
            this.button_bilgi_unuttum.Location = new System.Drawing.Point(15, 61);
            this.button_bilgi_unuttum.Name = "button_bilgi_unuttum";
            this.button_bilgi_unuttum.Size = new System.Drawing.Size(96, 23);
            this.button_bilgi_unuttum.TabIndex = 3;
            this.button_bilgi_unuttum.Text = "Şifremi Unuttum";
            this.button_bilgi_unuttum.UseVisualStyleBackColor = true;
            this.button_bilgi_unuttum.Click += new System.EventHandler(this.button_bilgi_unuttum_Click);
            // 
            // label_kayıt_olusturma
            // 
            this.label_kayıt_olusturma.AutoSize = true;
            this.label_kayıt_olusturma.Location = new System.Drawing.Point(22, 98);
            this.label_kayıt_olusturma.Name = "label_kayıt_olusturma";
            this.label_kayıt_olusturma.Size = new System.Drawing.Size(179, 13);
            this.label_kayıt_olusturma.TabIndex = 5;
            this.label_kayıt_olusturma.Text = "Yeni Kayıt Oluşturmak İçin Tıklayınız.";
            this.label_kayıt_olusturma.Click += new System.EventHandler(this.label_kayıt_olusturma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Oğuz Kaan Çırak";
            // 
            // personel_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(230, 130);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_kullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.button_bilgi_unuttum);
            this.Controls.Add(this.label_kayıt_olusturma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "personel_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoşgeldiniz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.personel_giris_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.TextBox textBox_kullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Button button_bilgi_unuttum;
        private System.Windows.Forms.Label label_kayıt_olusturma;
        private System.Windows.Forms.Label label3;
    }
}