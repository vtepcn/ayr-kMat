using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayrıkMat
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
            txtBoxAd.Focus();
        }
        
        public string ad = "et";
        public int sifre = 123;
        public int lang =0;  // 0 ingilizce 1 türkçe
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBoxAd.Text==ad  && txtBoxSifre.Text==sifre.ToString())
            {
                Aypp Aypp=new Aypp();
                Aypp.Show();
                this.Hide();
                
            }
            else
            {
                lblMesaj.Text = "Kullanıcı adı veye şifre yanlış !";   
            }
        }

        private void FormGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBoxAd.Text = " ";
            txtBoxSifre.Text=" ";
        }

       //İptal butonu
        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        
        //Dil değişim butonu
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            if (btnEnglish.Text == "ENGLISH")
            {
                lang = 0;
                btnGiris.Text = "ENTER";
                btnTemizle.Text = "CLEAR";
                btnIptal.Text = "CANCEL";
                btnEnglish.Text="TÜRKÇE";
                label1.Text = "USER NAME:";
                label2.Text="USER PASSWORD:";

            }
            else
            {
                lang = 1;
                btnGiris.Text = "GİRİŞ";
                btnTemizle.Text = "TEMİZLE";
                btnIptal.Text = "İPTAL";
                btnEnglish.Text = "ENGLISH";
                label1.Text = "Kullanıcı Adı:";
                label2.Text = "Kullanıcı Şifresi:";
            }

        }
    }
}
