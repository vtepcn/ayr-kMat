using System;
using System.CodeDom.Compiler;
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
    // Seçilen girdinin Girdi 1 mi Girdi 2 mi olduğunu nereden anlayacam?
    public partial class Aypp : Form
    {
        public bool p = true;
        public bool q = false;

        // P veya Q'nun mantıksal işlemini hesapla
        public  bool pOrq = p;

        public Aypp()
        {
            InitializeComponent();
            DataGridView dgv = new DataGridView();
            
            dgv.Rows[0].Cells[0].Value = p;
            dgv.Rows[0].Cells[1].Value = q;
        }

        private void Aypp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
        
        //Dil değiştirme butonu
        private void button22_Click(object sender, EventArgs e)
        {
                        
        }
        
        public void btnVe_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "VE";
            txtGirdi1.Update();
        }
       

        public void btnVeya_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "VEYA";
            txtGirdi1.Update();
        }

        public void btnDegil_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "NOT";
            txtGirdi1.Update();
            
        }

        public void btnXor_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "XOR";
            txtGirdi1.Update();
        }

        public void btnEqu_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "EQU";
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text  += "IMP";
        }

        private void btnParantezz1_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "(";
        }

        private void btnParantez2_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += ")";
        }

        private void btnNand_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "NAND";

        }

        private void btnNor_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "NOR";
        }

        private void btnGirdi1Temizle_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text = " ";
        }


        private void btnP_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "P";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "Q";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "R";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtGirdi1.Text += "S"; 

        }

       
        
    }
}
