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
    public partial class frmPROFESSION : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        //functions --------------------------------------------------------------------------------------------------------------
        public  void data_load()
        {
            try
            {
                var q = from x in dc.PROFESSIONs select x;
                advancedDataGridView1.DataSource = q.ToList();
            }
            catch { }
           
        }
        public void clearit()
{
    textBoxINTITULE.Clear();
    textBoxPRIME.Clear();
    textBoxSALAIRE.Clear();
}















        //METHODES-----------------------------------------------------
        public frmPROFESSION()
        {
            InitializeComponent();
        }

        private void frmPROFESSION_Load(object sender, EventArgs e)
        {
         
            data_load();
        }
        //ajout----------------------------------------------------------
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PROFESSION p = new PROFESSION();
                p.INTITULE = textBoxINTITULE.Text;
                p.SALAIRE = float.Parse(textBoxSALAIRE.Text);
                p.PRIME = float.Parse(textBoxPRIME.Text);
                dc.PROFESSIONs.InsertOnSubmit(p);
                dc.SubmitChanges();
                MessageBox.Show("ajout effectué avec succés !");
                clearit();
                data_load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        //modification---------------------------------------------------------------------------------------------------------------
        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var q = (from x in dc.PROFESSIONs where x.CODE_PROFESSION == int.Parse(textBoxCODE.Text) select x).Single();
                if (MessageBox.Show("voulez vous modifier la profession code= "+q.CODE_PROFESSION+" ?","modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    q.INTITULE = textBoxINTITULE.Text;
                    q.PRIME = float.Parse(textBoxPRIME.Text);
                    q.SALAIRE = float.Parse(textBoxSALAIRE.Text);
                    dc.SubmitChanges();
                    MessageBox.Show("modification effectué avec succés !");
                    data_load();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // suppression -----------------------------------------------------------------------------------------------------
        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("voulez-vous supprimez ?", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var q = (from x in dc.PROFESSIONs where x.CODE_PROFESSION == int.Parse(textBoxCODE.Text) select x).Single();
                    dc.PROFESSIONs.DeleteOnSubmit(q);
                    dc.SubmitChanges();
                    MessageBox.Show("suppression effectué");
                    data_load();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //search----------------------------------------------------------------------------------------------------------------------

        //selection-------------------------------------------------------------------------------------------------------------------
        private void advancedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBoxCODE.Text = advancedDataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxINTITULE.Text = advancedDataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSALAIRE.Text = advancedDataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPRIME.Text = advancedDataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var q = (from x in dc.PROFESSIONs where x.INTITULE.StartsWith(textBoxSearch.Text.ToString()) select x).Single();
                clearit();
                textBoxCODE.Text = q.CODE_PROFESSION.ToString();
                textBoxINTITULE.Text = q.INTITULE;
                textBoxPRIME.Text = q.PRIME.ToString();
                textBoxSALAIRE.Text = q.SALAIRE.ToString();
            }
            catch { }
        }

    }
}
