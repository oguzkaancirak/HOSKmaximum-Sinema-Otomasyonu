namespace HOSKmaximum
{
    partial class film_secim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_film_select = new System.Windows.Forms.ComboBox();
            this.comboBox_salon_select = new System.Windows.Forms.ComboBox();
            this.comboBox_seans_select = new System.Windows.Forms.ComboBox();
            this.button_REZERVASYON = new System.Windows.Forms.Button();
            this.button_FILMEKLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salonu Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seansınızı Seçiniz";
            // 
            // comboBox_film_select
            // 
            this.comboBox_film_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_film_select.FormattingEnabled = true;
            this.comboBox_film_select.Location = new System.Drawing.Point(231, 55);
            this.comboBox_film_select.Name = "comboBox_film_select";
            this.comboBox_film_select.Size = new System.Drawing.Size(200, 21);
            this.comboBox_film_select.TabIndex = 3;
            this.comboBox_film_select.Click += new System.EventHandler(this.comboBox_film_select_Click);
            // 
            // comboBox_salon_select
            // 
            this.comboBox_salon_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_salon_select.FormattingEnabled = true;
            this.comboBox_salon_select.Location = new System.Drawing.Point(231, 82);
            this.comboBox_salon_select.Name = "comboBox_salon_select";
            this.comboBox_salon_select.Size = new System.Drawing.Size(200, 21);
            this.comboBox_salon_select.TabIndex = 4;
            this.comboBox_salon_select.Click += new System.EventHandler(this.comboBox_salon_select_Click);
            // 
            // comboBox_seans_select
            // 
            this.comboBox_seans_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_seans_select.FormattingEnabled = true;
            this.comboBox_seans_select.Items.AddRange(new object[] {
            "11:00",
            "13:00",
            "15:00",
            "17:00",
            "19:00"});
            this.comboBox_seans_select.Location = new System.Drawing.Point(231, 109);
            this.comboBox_seans_select.Name = "comboBox_seans_select";
            this.comboBox_seans_select.Size = new System.Drawing.Size(200, 21);
            this.comboBox_seans_select.TabIndex = 5;
            // 
            // button_REZERVASYON
            // 
            this.button_REZERVASYON.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_REZERVASYON.Location = new System.Drawing.Point(107, 159);
            this.button_REZERVASYON.Name = "button_REZERVASYON";
            this.button_REZERVASYON.Size = new System.Drawing.Size(324, 45);
            this.button_REZERVASYON.TabIndex = 6;
            this.button_REZERVASYON.Text = "Rezervasyon Yap";
            this.button_REZERVASYON.UseVisualStyleBackColor = true;
            this.button_REZERVASYON.Click += new System.EventHandler(this.button_REZERVASYON_Click);
            // 
            // button_FILMEKLE
            // 
            this.button_FILMEKLE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_FILMEKLE.Location = new System.Drawing.Point(107, 226);
            this.button_FILMEKLE.Name = "button_FILMEKLE";
            this.button_FILMEKLE.Size = new System.Drawing.Size(324, 45);
            this.button_FILMEKLE.TabIndex = 7;
            this.button_FILMEKLE.Text = "Film Ekle";
            this.button_FILMEKLE.UseVisualStyleBackColor = true;
            this.button_FILMEKLE.Click += new System.EventHandler(this.button_FILMEKLE_Click);
            // 
            // film_secim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HOSKmaximum.Properties.Resources.beautiful_red_chairs_on_the_cinema_hd_wallpaper_1440x900;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 363);
            this.Controls.Add(this.button_FILMEKLE);
            this.Controls.Add(this.button_REZERVASYON);
            this.Controls.Add(this.comboBox_seans_select);
            this.Controls.Add(this.comboBox_salon_select);
            this.Controls.Add(this.comboBox_film_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(580, 402);
            this.MinimumSize = new System.Drawing.Size(580, 402);
            this.Name = "film_secim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Seçim Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_film_select;
        private System.Windows.Forms.ComboBox comboBox_salon_select;
        private System.Windows.Forms.ComboBox comboBox_seans_select;
        private System.Windows.Forms.Button button_REZERVASYON;
        private System.Windows.Forms.Button button_FILMEKLE;
    }
}