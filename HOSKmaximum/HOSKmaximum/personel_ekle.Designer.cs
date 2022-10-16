namespace HOSKmaximum
{
    partial class personel_ekle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_geridon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_EKLE = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SIFRE_EKLE = new System.Windows.Forms.TextBox();
            this.txt_PID_EKLE = new System.Windows.Forms.TextBox();
            this.txt_NO_EKLE = new System.Windows.Forms.TextBox();
            this.button_EKLE = new System.Windows.Forms.Button();
            this.groupBox_GUNCELLE = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SIFRE_UPDATE = new System.Windows.Forms.TextBox();
            this.txt_PID_UPDATE = new System.Windows.Forms.TextBox();
            this.txt_NO_UPDATE = new System.Windows.Forms.TextBox();
            this.button_UPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_EKLE.SuspendLayout();
            this.groupBox_GUNCELLE.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_delete.Location = new System.Drawing.Point(404, 153);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(92, 170);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "KAYIT SİL";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_geridon
            // 
            this.button_geridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_geridon.Location = new System.Drawing.Point(12, 329);
            this.button_geridon.Name = "button_geridon";
            this.button_geridon.Size = new System.Drawing.Size(482, 23);
            this.button_geridon.TabIndex = 17;
            this.button_geridon.Text = "GERİ DÖN";
            this.button_geridon.UseVisualStyleBackColor = true;
            this.button_geridon.Click += new System.EventHandler(this.button_geridon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(386, 170);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_EKLE
            // 
            this.groupBox_EKLE.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_EKLE.Controls.Add(this.label3);
            this.groupBox_EKLE.Controls.Add(this.label2);
            this.groupBox_EKLE.Controls.Add(this.label1);
            this.groupBox_EKLE.Controls.Add(this.txt_SIFRE_EKLE);
            this.groupBox_EKLE.Controls.Add(this.txt_PID_EKLE);
            this.groupBox_EKLE.Controls.Add(this.txt_NO_EKLE);
            this.groupBox_EKLE.Controls.Add(this.button_EKLE);
            this.groupBox_EKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_EKLE.ForeColor = System.Drawing.Color.Black;
            this.groupBox_EKLE.Location = new System.Drawing.Point(12, 14);
            this.groupBox_EKLE.Name = "groupBox_EKLE";
            this.groupBox_EKLE.Size = new System.Drawing.Size(238, 133);
            this.groupBox_EKLE.TabIndex = 14;
            this.groupBox_EKLE.TabStop = false;
            this.groupBox_EKLE.Text = "EKLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "PERSONEL ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "NO";
            // 
            // txt_SIFRE_EKLE
            // 
            this.txt_SIFRE_EKLE.Location = new System.Drawing.Point(121, 72);
            this.txt_SIFRE_EKLE.Name = "txt_SIFRE_EKLE";
            this.txt_SIFRE_EKLE.Size = new System.Drawing.Size(100, 20);
            this.txt_SIFRE_EKLE.TabIndex = 4;
            // 
            // txt_PID_EKLE
            // 
            this.txt_PID_EKLE.Location = new System.Drawing.Point(121, 46);
            this.txt_PID_EKLE.Name = "txt_PID_EKLE";
            this.txt_PID_EKLE.Size = new System.Drawing.Size(100, 20);
            this.txt_PID_EKLE.TabIndex = 3;
            // 
            // txt_NO_EKLE
            // 
            this.txt_NO_EKLE.Location = new System.Drawing.Point(121, 20);
            this.txt_NO_EKLE.Name = "txt_NO_EKLE";
            this.txt_NO_EKLE.Size = new System.Drawing.Size(100, 20);
            this.txt_NO_EKLE.TabIndex = 2;
            // 
            // button_EKLE
            // 
            this.button_EKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_EKLE.ForeColor = System.Drawing.Color.Black;
            this.button_EKLE.Location = new System.Drawing.Point(19, 98);
            this.button_EKLE.Name = "button_EKLE";
            this.button_EKLE.Size = new System.Drawing.Size(202, 23);
            this.button_EKLE.TabIndex = 0;
            this.button_EKLE.Text = "EKLE";
            this.button_EKLE.UseVisualStyleBackColor = true;
            this.button_EKLE.Click += new System.EventHandler(this.button_EKLE_Click);
            // 
            // groupBox_GUNCELLE
            // 
            this.groupBox_GUNCELLE.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_GUNCELLE.Controls.Add(this.label6);
            this.groupBox_GUNCELLE.Controls.Add(this.label7);
            this.groupBox_GUNCELLE.Controls.Add(this.label8);
            this.groupBox_GUNCELLE.Controls.Add(this.txt_SIFRE_UPDATE);
            this.groupBox_GUNCELLE.Controls.Add(this.txt_PID_UPDATE);
            this.groupBox_GUNCELLE.Controls.Add(this.txt_NO_UPDATE);
            this.groupBox_GUNCELLE.Controls.Add(this.button_UPDATE);
            this.groupBox_GUNCELLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_GUNCELLE.ForeColor = System.Drawing.Color.Black;
            this.groupBox_GUNCELLE.Location = new System.Drawing.Point(258, 12);
            this.groupBox_GUNCELLE.Name = "groupBox_GUNCELLE";
            this.groupBox_GUNCELLE.Size = new System.Drawing.Size(238, 135);
            this.groupBox_GUNCELLE.TabIndex = 19;
            this.groupBox_GUNCELLE.TabStop = false;
            this.groupBox_GUNCELLE.Text = "GÜNCELLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "SOYAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "AD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID";
            // 
            // txt_SIFRE_UPDATE
            // 
            this.txt_SIFRE_UPDATE.Location = new System.Drawing.Point(108, 75);
            this.txt_SIFRE_UPDATE.Name = "txt_SIFRE_UPDATE";
            this.txt_SIFRE_UPDATE.Size = new System.Drawing.Size(100, 20);
            this.txt_SIFRE_UPDATE.TabIndex = 4;
            // 
            // txt_PID_UPDATE
            // 
            this.txt_PID_UPDATE.Location = new System.Drawing.Point(108, 49);
            this.txt_PID_UPDATE.Name = "txt_PID_UPDATE";
            this.txt_PID_UPDATE.Size = new System.Drawing.Size(100, 20);
            this.txt_PID_UPDATE.TabIndex = 3;
            // 
            // txt_NO_UPDATE
            // 
            this.txt_NO_UPDATE.Location = new System.Drawing.Point(108, 23);
            this.txt_NO_UPDATE.Name = "txt_NO_UPDATE";
            this.txt_NO_UPDATE.ReadOnly = true;
            this.txt_NO_UPDATE.Size = new System.Drawing.Size(100, 20);
            this.txt_NO_UPDATE.TabIndex = 2;
            // 
            // button_UPDATE
            // 
            this.button_UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_UPDATE.ForeColor = System.Drawing.Color.Black;
            this.button_UPDATE.Location = new System.Drawing.Point(29, 100);
            this.button_UPDATE.Name = "button_UPDATE";
            this.button_UPDATE.Size = new System.Drawing.Size(179, 23);
            this.button_UPDATE.TabIndex = 0;
            this.button_UPDATE.Text = "GUNCELLE";
            this.button_UPDATE.UseVisualStyleBackColor = true;
            this.button_UPDATE.Click += new System.EventHandler(this.button_UPDATE_Click);
            // 
            // personel_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::HOSKmaximum.Properties.Resources.user;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 368);
            this.Controls.Add(this.groupBox_GUNCELLE);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_geridon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_EKLE);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(524, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(524, 407);
            this.Name = "personel_ekle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt Ekleme-Güncelleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.personel_ekle_FormClosing);
            this.Load += new System.EventHandler(this.personel_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_EKLE.ResumeLayout(false);
            this.groupBox_EKLE.PerformLayout();
            this.groupBox_GUNCELLE.ResumeLayout(false);
            this.groupBox_GUNCELLE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_geridon;
        private System.Windows.Forms.GroupBox groupBox_EKLE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SIFRE_EKLE;
        private System.Windows.Forms.TextBox txt_PID_EKLE;
        private System.Windows.Forms.TextBox txt_NO_EKLE;
        private System.Windows.Forms.Button button_EKLE;
        private System.Windows.Forms.GroupBox groupBox_GUNCELLE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SIFRE_UPDATE;
        private System.Windows.Forms.TextBox txt_PID_UPDATE;
        private System.Windows.Forms.TextBox txt_NO_UPDATE;
        private System.Windows.Forms.Button button_UPDATE;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}