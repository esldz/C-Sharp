using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace takim_eslesme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList takim = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            takim.Add(txtTakim.Text);
            lstTakimlar.Items.Add(txtTakim.Text);

            txtTakim.Clear();
            txtTakim.Focus();
        }
        Random random = new Random();
        private void btnEslestir_Click(object sender, EventArgs e)
        {
            while(i<takim.Count)
            {
                int indeks1 = random.Next(takim.Count);
                int indeks2 = random.Next(takim.Count);

                int yoksa = Array.IndexOf(takim, indeks1);
                int yoksa2 = Array.IndexOf(takim, indeks2);

                if (yoksa == -1 && yoksa2 == -1)
                {
                    takim[i] = indeks1;
                    takim[i] = indeks2;
                }
            }
        }
    }
}
