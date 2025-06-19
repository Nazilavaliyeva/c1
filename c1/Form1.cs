using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace c1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private List<string[]> melumatlar = new List<string[]>();

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string dogum = txtTarix.Text;
            string olke = txtMilliyyet.Text;

            string[] melumat = new string[] { ad, soyad, dogum, olke };
            melumatlar.Add(melumat);
            comboBox1.Items.Add(ad + " " + soyad);
            MessageBox.Show("Əlavə olundu: " + melumatlar.Count + " nəfər");

            txtAd.Clear();
            txtSoyad.Clear();
            txtTarix.Clear();
            txtMilliyyet.Clear();
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= 0 && index < melumatlar.Count)
            {
                string[] secilmis = melumatlar[index];
                txtAd.Text = secilmis[0];
                txtSoyad.Text = secilmis[1];
                txtTarix.Text = secilmis[2];
                txtMilliyyet.Text = secilmis[3];
            }
        }
    }
}