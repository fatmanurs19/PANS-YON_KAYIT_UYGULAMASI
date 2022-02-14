namespace PANSİYON_KAYIT_UYGULAMASI
{
    partial class frmMusteriler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerileriGoster = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 326);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1133, 211);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NO";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ADI";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOYADI";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CİNSİYET";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TELEFON";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MAIL";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC";
            this.columnHeader7.Width = 76;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ODA NO";
            this.columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ÜCRET";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "GİRİŞ TARİHİ";
            this.columnHeader10.Width = 103;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ÇIKIŞ TARİHİ";
            this.columnHeader11.Width = 109;
            // 
            // btnVerileriGoster
            // 
            this.btnVerileriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerileriGoster.Location = new System.Drawing.Point(924, 12);
            this.btnVerileriGoster.Name = "btnVerileriGoster";
            this.btnVerileriGoster.Size = new System.Drawing.Size(194, 60);
            this.btnVerileriGoster.TabIndex = 1;
            this.btnVerileriGoster.Text = "VERİLERİ GÖSTER";
            this.btnVerileriGoster.UseVisualStyleBackColor = true;
            this.btnVerileriGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(924, 232);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(194, 43);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(924, 83);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(194, 47);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(924, 136);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(194, 42);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.BackColor = System.Drawing.Color.White;
            this.txtTCKimlikNo.Location = new System.Drawing.Point(160, 209);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(200, 22);
            this.txtTCKimlikNo.TabIndex = 42;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(160, 98);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(199, 24);
            this.cmbCinsiyet.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(28, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "Cinsiyet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(468, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Oda Numarası";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.BackColor = System.Drawing.Color.White;
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Location = new System.Drawing.Point(625, 22);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(200, 22);
            this.txtOdaNo.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(468, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ücret";
            // 
            // txtUcret
            // 
            this.txtUcret.BackColor = System.Drawing.Color.White;
            this.txtUcret.Location = new System.Drawing.Point(625, 57);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(200, 22);
            this.txtUcret.TabIndex = 36;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.CalendarFont = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGirisTarihi.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpGirisTarihi.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpGirisTarihi.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpGirisTarihi.CalendarTrailingForeColor = System.Drawing.Color.LightGray;
            this.dtpGirisTarihi.Location = new System.Drawing.Point(625, 94);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpGirisTarihi.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Adı";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.CalendarFont = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCikisTarihi.Location = new System.Drawing.Point(625, 131);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpCikisTarihi.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(160, 170);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "TC Kimlik No";
            // 
            // mskTxtTelefon
            // 
            this.mskTxtTelefon.Location = new System.Drawing.Point(160, 134);
            this.mskTxtTelefon.Mask = "(999) 000-0000";
            this.mskTxtTelefon.Name = "mskTxtTelefon";
            this.mskTxtTelefon.Size = new System.Drawing.Size(200, 22);
            this.mskTxtTelefon.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(468, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Giriş Tarihi";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.BackColor = System.Drawing.Color.White;
            this.txtSoyadi.Location = new System.Drawing.Point(160, 60);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 22);
            this.txtSoyadi.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(468, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Çıkış Tarihi";
            // 
            // txtAdi
            // 
            this.txtAdi.BackColor = System.Drawing.Color.White;
            this.txtAdi.Location = new System.Drawing.Point(160, 22);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 22);
            this.txtAdi.TabIndex = 30;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(924, 184);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(194, 42);
            this.btnTemizle.TabIndex = 43;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(979, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(942, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "İsim";
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1276, 539);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTxtTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnVerileriGoster);
            this.Controls.Add(this.listView1);
            this.Name = "frmMusteriler";
            this.Text = "Müşteri Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnVerileriGoster;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTxtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
    }
}