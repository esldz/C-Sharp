namespace takim_eslesme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEslestir = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTakim = new System.Windows.Forms.TextBox();
            this.lstEslestirme = new System.Windows.Forms.ListBox();
            this.lstTakimlar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEslestir
            // 
            this.btnEslestir.Location = new System.Drawing.Point(221, 11);
            this.btnEslestir.Name = "btnEslestir";
            this.btnEslestir.Size = new System.Drawing.Size(144, 45);
            this.btnEslestir.TabIndex = 1;
            this.btnEslestir.Text = "Eşleştir";
            this.btnEslestir.UseVisualStyleBackColor = true;
            this.btnEslestir.Click += new System.EventHandler(this.btnEslestir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 44);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(144, 25);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Takım Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTakim
            // 
            this.txtTakim.Location = new System.Drawing.Point(13, 12);
            this.txtTakim.Name = "txtTakim";
            this.txtTakim.Size = new System.Drawing.Size(143, 20);
            this.txtTakim.TabIndex = 3;
            // 
            // lstEslestirme
            // 
            this.lstEslestirme.FormattingEnabled = true;
            this.lstEslestirme.Location = new System.Drawing.Point(192, 62);
            this.lstEslestirme.Name = "lstEslestirme";
            this.lstEslestirme.Size = new System.Drawing.Size(203, 316);
            this.lstEslestirme.TabIndex = 4;
            // 
            // lstTakimlar
            // 
            this.lstTakimlar.FormattingEnabled = true;
            this.lstTakimlar.Location = new System.Drawing.Point(13, 75);
            this.lstTakimlar.Name = "lstTakimlar";
            this.lstTakimlar.Size = new System.Drawing.Size(143, 303);
            this.lstTakimlar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 384);
            this.Controls.Add(this.lstTakimlar);
            this.Controls.Add(this.lstEslestirme);
            this.Controls.Add(this.txtTakim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnEslestir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEslestir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTakim;
        private System.Windows.Forms.ListBox lstEslestirme;
        private System.Windows.Forms.ListBox lstTakimlar;
    }
}

