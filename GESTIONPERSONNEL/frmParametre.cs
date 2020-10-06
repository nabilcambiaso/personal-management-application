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
    public partial class frmParametre : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public string userName;
        public frmParametre(string user)
        {
            this.userName = user;
            InitializeComponent();
        }

        private void frmParametre_Load(object sender, EventArgs e)
        {
            textBox4.Text = userName;
            var q = from x in dc.TRAVAILs select x;
            comboBox1.DataSource = q.ToList();
            comboBox1.ValueMember = "CIN";
            comboBox1.DisplayMember = "CIN";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox6.UseSystemPasswordChar = false;
            }else
            {
                textBox6.UseSystemPasswordChar = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("voulez vous modifier ?","modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
   var q = (from x in dc.ADMINs where x.USERNAME == textBox4.Text select x).Single();
                if (q.PASSWORD == textBox5.Text.ToString())
                {
                    q.PASSWORD = textBox6.Text;
                    dc.SubmitChanges();
                    MessageBox.Show("mot de passe changé avec succés !");
                    
                }
                else
                {
                    MessageBox.Show("ancien mot de passe incorrect !");
                }
                }
             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                USER u = new USER();
                u.CIN = comboBox1.SelectedValue.ToString();
                u.USERNAME = textBox3.Text;
                u.PASSWORD = textBox1.Text;
                dc.USERs.InsertOnSubmit(u);
                dc.SubmitChanges();
                MessageBox.Show("utilisateur ajouter avec succes");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var q = (from x in dc.PERSONNELs where x.CIN == comboBox1.SelectedValue.ToString() select x.NOM + " " + x.PRENOM).Single();
                textBox3.Text = q.ToString();
            }
            catch { }
            
        }
    }
}
