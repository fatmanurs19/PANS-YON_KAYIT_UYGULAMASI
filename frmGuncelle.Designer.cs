namespace PANSİYON_KAYIT_UYGULAMASI
{
    partial class frmGuncelle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.txtKullanici2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(550, 277);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(154, 45);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSifre2
            // 
            this.txtSifre2.BackColor = System.Drawing.Color.Ivory;
            this.txtSifre2.Location = new System.Drawing.Point(550, 221);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.PasswordChar = '*';
            this.txtSifre2.Size = new System.Drawing.Size(197, 22);
            this.txtSifre2.TabIndex = 8;
            this.txtSifre2.UseSystemPasswordChar = true;
            // 
            // txtKullanici2
            // 
            this.txtKullanici2.BackColor = System.Drawing.Color.Ivory;
            this.txtKullanici2.Location = new System.Drawing.Point(550, 176);
            this.txtKullanici2.Name = "txtKullanici2";
            this.txtKullanici2.Size = new System.Drawing.Size(197, 22);
            this.txtKullanici2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(381, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(381, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // frmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1260, 518);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.txtKullanici2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGuncelle";
            this.Text = "frmGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.TextBox txtKullanici2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}