namespace HOSKmaximum
{
    partial class sifreUnuttum
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_konu = new System.Windows.Forms.TextBox();
            this.richTextBox_mesaj = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Konu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID-YENI SIFRE OLARAK GIRIS YAPINIZ";
            // 
            // textBox_konu
            // 
            this.textBox_konu.Location = new System.Drawing.Point(60, 6);
            this.textBox_konu.Name = "textBox_konu";
            this.textBox_konu.ReadOnly = true;
            this.textBox_konu.Size = new System.Drawing.Size(155, 20);
            this.textBox_konu.TabIndex = 6;
            this.textBox_konu.Text = "Şifremi Unuttum";
            // 
            // richTextBox_mesaj
            // 
            this.richTextBox_mesaj.Location = new System.Drawing.Point(12, 53);
            this.richTextBox_mesaj.Name = "richTextBox_mesaj";
            this.richTextBox_mesaj.Size = new System.Drawing.Size(212, 125);
            this.richTextBox_mesaj.TabIndex = 1;
            this.richTextBox_mesaj.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sifreUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(233, 217);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_mesaj);
            this.Controls.Add(this.textBox_konu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(249, 256);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(249, 256);
            this.Name = "sifreUnuttum";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Yenileme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sifreUnuttum_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_konu;
        private System.Windows.Forms.RichTextBox richTextBox_mesaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}