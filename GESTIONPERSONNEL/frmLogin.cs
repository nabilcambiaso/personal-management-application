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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox1.Checked)
           {
              
               textBox2.UseSystemPasswordChar = false;
           }
           else
           {
               textBox2.UseSystemPasswordChar = true;
           }
        }
        string admin = "nabil";
        string pass = "123";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var q = (from x in dc.ADMINs where x.USERNAME == textBox1.Text && x.PASSWORD == textBox2.Text select x).Single();
if(q!=null)
{
    frmHOME f = new frmHOME(q.USERNAME);
    f.Show();
    MessageBox.Show("Welcome !");
    this.Hide();
}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
