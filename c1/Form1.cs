using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            
            try
            {
                string secim = comboBox1.Text;
                if (secim == "Ali Valiyev")
                {
                    txtAd.Text = "Ali";
                    txtSoyad.Text = "Valiyev";
                    txtTarix.Text = "11.04.2016";
                    txtMilliyyet.Text = "Azerbaycanli";
                }
                else if(secim == "Elman Qasimov")
                {
                    txtAd.Text = "Elman";
                    txtSoyad.Text = "Qasimov";
                    txtTarix.Text = "15.04.2001";
                    txtMilliyyet.Text = "Azerbaycanli";
                }
                else
                {
                    MessageBox.Show("Məlumat tapilmadı", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta: " + ex.Message, "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
         
           

            

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTarix.Clear();
            txtMilliyyet.Clear();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ali Valiyev");
            comboBox1.Items.Add("Elman Qasimov");
        }
    }
}
