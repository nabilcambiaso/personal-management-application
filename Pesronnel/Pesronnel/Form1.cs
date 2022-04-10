using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesronnel
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string cin;
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var q = (from x in dc.USERs where x.USERNAME == textBox1.Text && x.PASSWORD == textBox2.Text select x).Single();
                cin = q.CIN;
                if(q!=null)
                {
                    frmACCEUIL f = new frmACCEUIL(cin);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("userName or password incorrect !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
