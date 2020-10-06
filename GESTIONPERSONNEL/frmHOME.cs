using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GESTIONPERSONNEL
{
    public partial class frmHOME : Form
    {
        public string userName;
        public frmHOME(string user)
        {
            this.userName = user;
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Focus();
 
        }
        
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            frmPERSONNEL f = new frmPERSONNEL();

            f.ShowDialog();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            metroButton1_Click_1(sender,e);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            metroButton2_Click_1(sender, e);
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            frmPROFESSION F = new frmPROFESSION();
            F.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            metroButton3_Click_1(sender,e);
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            frmTRAVAIL f = new frmTRAVAIL();
            f.ShowDialog();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            metroButton4_Click_1(sender, e);
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            frmConge f = new frmConge();
            f.ShowDialog();
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            frmPayement p = new frmPayement();
            p.ShowDialog();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            frmParametre f = new frmParametre(userName);
            f.ShowDialog();
        }

        private void frmHOME_FormClosed(object sender, FormClosedEventArgs e)
        {
           if( MessageBox.Show("voulez vous quitter l'application ?","Quitter",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
           {
               Application.Exit();
           }
        }
    }
}
