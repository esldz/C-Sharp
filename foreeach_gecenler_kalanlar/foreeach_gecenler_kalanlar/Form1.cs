using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace foreeach_gecenler_kalanlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler=new string[5];
        int[] notlar=new int[5];
        int index=0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdSoyad.Text == "")
                {
                    txtAdSoyad.Text = "Ad-Soyad giriniz";
                    txtAdSoyad.Focus();
                    txtAdSoyad.SelectAll();
                }
                else
                {
                    isimler[index] = txtAdSoyad.Text;
                    notlar[index] = Convert.ToInt32(txtDersNotu.Text);
                    index++;
                    txtAdSoyad.Clear();
                    txtDersNotu.Clear();
                    txtAdSoyad.Focus();
                }
                if (index == isimler.Length)
                {
                    MessageBox.Show("Dizi doldu");
                    btnEkle.Enabled = false;
                    txtAdSoyad.Enabled = false;
                    txtDersNotu.Enabled = false;
                    btnListele.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Sayısal değer gir");
                txtDersNotu.Focus();
                txtDersNotu.SelectAll();
            }
        }

        private void btnEnYüksek_Click(object sender, EventArgs e)
        {
            int enYuksek = notlar[0];
            foreach (int not in notlar)
            {
                if (notlar[not] > enYuksek)
                {
                    enYuksek = notlar[not];
                }
            }
            txtEnYüksek.Text = enYuksek.ToString();
        }

        private void btnEnDüşük_Click(object sender, EventArgs e)
        {
            int enDusuk = notlar[0];
            foreach (int not in notlar)
            {
                if (notlar[not] < enDusuk)
                {
                    enDusuk = notlar[not];
                }
            }
            txtEnDüşük.Text = enDusuk.ToString();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (int not in notlar)
            {
                toplam += not;
            }
            txtOrtalama.Text = (toplam / notlar.Length).ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            foreach (int not in notlar)
            {
                if (notlar[not] >= 50)
                {
                    lstGecenler.Items.Add(isimler[not]+"-"+ notlar[not]);
                }
                else
                {
                    lstKalanlar.Items.Add(isimler[not] + "-" + notlar[not]);
                }
            }
        }
    }
}
