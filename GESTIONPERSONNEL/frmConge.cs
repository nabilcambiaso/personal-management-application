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
    public partial class frmConge : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        //functions----------------------------
        void hides()
        {
            foreach(Control item in this.Controls)
            {
                if(item.GetType()==typeof(Label) || item.GetType()==typeof(TextBox) || item.GetType()==typeof(Button))
                {
                    item.Hide();
                }
            }
        }
        void shows()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(Label) || item.GetType() == typeof(TextBox) || item.GetType() == typeof(Button))
                {
                    item.Show();
                }
            }
        }










        //methodes--------------------------------------------------------------------------------------------------
        public frmConge()
        {
            InitializeComponent();
        }

        private void frmConge_Load(object sender, EventArgs e)
        {
            hides();

        }
        //CHECK EN COURS----------
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hides();
            try
            {
                
                foreach(CONGE item in dc.CONGEs)
                {
                    if((item.DATE_CONGE.AddDays(double.Parse(item.DUREE.ToString()))<=DateTime.Now))
                    {
                        item.ETAT = "TERMINE";
                        
                        dc.SubmitChanges();
                    }
                }
                var q = from x in dc.CONGEs where x.ETAT.Equals("EN COURS") select x;
                advancedDataGridView1.DataSource = q.ToList();
            }
            catch { }
            
        }
        //CHECK TERMINE----------

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            hides();
            try
            {
                var q = from x in dc.CONGEs where x.ETAT.Equals("TERMINE") select x;
                advancedDataGridView1.DataSource = q.ToList();
            }
            catch { }
            
        }
        //CHECK EN ATTENTE----------

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            shows();
            try
            {
                var q = from x in dc.CONGEs where x.ETAT.Equals("EN ATTENTE") select x;
                advancedDataGridView1.DataSource = q.ToList();
            }
            catch { }
          
        }
        //SELECTION ----------------------------------------------------------------

        // VALIDER CONGE -----------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("voulez-vous validez ce congé ?","validé!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    CONGE c = new CONGE();
                    var q = (from x in dc.CONGEs where x.CIN == textBox1.Text && x.DATE_CONGE==DateTime.Parse(textBox2.Text.ToString()) select x).Single();
                    q.DUREE = int.Parse(textBox3.Text);
                    q.ETAT = "EN COURS";
                    dc.SubmitChanges();
                    radioButton3_CheckedChanged(sender, e);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void advancedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = advancedDataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = advancedDataGridView1.CurrentRow.Cells[1].Value.ToString();

            
        }
    }
}
