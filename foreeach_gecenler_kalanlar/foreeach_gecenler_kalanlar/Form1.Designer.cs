namespace foreeach_gecenler_kalanlar
{
    partial class Form1
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtDersNotu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnEnYüksek = new System.Windows.Forms.Button();
            this.btnEnDüşük = new System.Windows.Forms.Button();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.txtEnDüşük = new System.Windows.Forms.TextBox();
            this.txtEnYüksek = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.lstGecenler = new System.Windows.Forms.ListBox();
            this.lstKalanlar = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad-soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ders notu";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(69, 19);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtDersNotu
            // 
            this.txtDersNotu.Location = new System.Drawing.Point(69, 61);
            this.txtDersNotu.Name = "txtDersNotu";
            this.txtDersNotu.Size = new System.Drawing.Size(100, 20);
            this.txtDersNotu.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(18, 97);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnEnYüksek
            // 
            this.btnEnYüksek.Location = new System.Drawing.Point(69, 136);
            this.btnEnYüksek.Name = "btnEnYüksek";
            this.btnEnYüksek.Size = new System.Drawing.Size(75, 23);
            this.btnEnYüksek.TabIndex = 5;
            this.btnEnYüksek.Text = "En Yüksek";
            this.btnEnYüksek.UseVisualStyleBackColor = true;
            this.btnEnYüksek.Click += new System.EventHandler(this.btnEnYüksek_Click);
            // 
            // btnEnDüşük
            // 
            this.btnEnDüşük.Location = new System.Drawing.Point(69, 181);
            this.btnEnDüşük.Name = "btnEnDüşük";
            this.btnEnDüşük.Size = new System.Drawing.Size(75, 23);
            this.btnEnDüşük.TabIndex = 6;
            this.btnEnDüşük.Text = "En Düşük";
            this.btnEnDüşük.UseVisualStyleBackColor = true;
            this.btnEnDüşük.Click += new System.EventHandler(this.btnEnDüşük_Click);
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Location = new System.Drawing.Point(69, 226);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(75, 23);
            this.btnOrtalama.TabIndex = 7;
            this.btnOrtalama.Text = "Ortalama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // txtEnDüşük
            // 
            this.txtEnDüşük.Enabled = false;
            this.txtEnDüşük.Location = new System.Drawing.Point(150, 181);
            this.txtEnDüşük.Name = "txtEnDüşük";
            this.txtEnDüşük.Size = new System.Drawing.Size(100, 20);
            this.txtEnDüşük.TabIndex = 8;
            // 
            // txtEnYüksek
            // 
            this.txtEnYüksek.Enabled = false;
            this.txtEnYüksek.Location = new System.Drawing.Point(150, 136);
            this.txtEnYüksek.Name = "txtEnYüksek";
            this.txtEnYüksek.Size = new System.Drawing.Size(100, 20);
            this.txtEnYüksek.TabIndex = 9;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Enabled = false;
            this.txtOrtalama.Location = new System.Drawing.Point(150, 229);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 10;
            // 
            // lstGecenler
            // 
            this.lstGecenler.FormattingEnabled = true;
            this.lstGecenler.Location = new System.Drawing.Point(280, 12);
            this.lstGecenler.Name = "lstGecenler";
            this.lstGecenler.Size = new System.Drawing.Size(120, 225);
            this.lstGecenler.TabIndex = 11;
            // 
            // lstKalanlar
            // 
            this.lstKalanlar.FormattingEnabled = true;
            this.lstKalanlar.Location = new System.Drawing.Point(417, 12);
            this.lstKalanlar.Name = "lstKalanlar";
            this.lstKalanlar.Size = new System.Drawing.Size(120, 225);
            this.lstKalanlar.TabIndex = 12;
            // 
            // btnListele
            // 
            this.btnListele.Enabled = false;
            this.btnListele.Location = new System.Drawing.Point(205, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(45, 105);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = ">>>";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 261);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lstKalanlar);
            this.Controls.Add(this.lstGecenler);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtEnYüksek);
            this.Controls.Add(this.txtEnDüşük);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.btnEnDüşük);
            this.Controls.Add(this.btnEnYüksek);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDersNotu);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "366";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtDersNotu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnEnYüksek;
        private System.Windows.Forms.Button btnEnDüşük;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.TextBox txtEnDüşük;
        private System.Windows.Forms.TextBox txtEnYüksek;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.ListBox lstGecenler;
        private System.Windows.Forms.ListBox lstKalanlar;
        private System.Windows.Forms.Button btnListele;
    }
}

