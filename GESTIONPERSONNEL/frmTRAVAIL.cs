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
    public partial class frmTRAVAIL : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        //functions-------------------------------------------------------------------------
        private void remplissage()
        {
            var q = from x in dc.PERSONNELs select x;
            comboBoxCIN.DataSource = q.ToList();
            comboBoxCIN.ValueMember = "CIN";
            comboBoxCIN.DisplayMember = "CIN";
            comboBoxPROFESSION.DataSource = dc.PROFESSIONs;
            comboBoxPROFESSION.ValueMember = "CODE_PROFESSION";
            comboBoxPROFESSION.DisplayMember = "INTITULE";
        }
        private void data_load ()
        {
            try
            {
                var q = from x in dc.TRAVAILs
                        select new
                        {
                            code_Profession = x.CODE_PROFESSION,
                            Code_Identite_Nationale = x.CIN,
                            Nom = (from y in dc.PERSONNELs where x.CIN == y.CIN select y.NOM).Single(),
                            Prenom = (from y1 in dc.PERSONNELs where x.CIN == y1.CIN select y1.PRENOM).Single(),
                            Date_Engagement = x.DATE_TRAVAIL,
                            Duree_Service = x.DUREE,
                            Date_Fin = x.DATE_TRAVAIL.Value.AddMonths(int.Parse(x.DUREE.ToString())).ToShortDateString()


                        };
                advancedDataGridView1.DataSource = q.ToList();
            }
            catch { }
         
        }

        //methodes-------------------------------------------------------------------------------
        
        public frmTRAVAIL()
        {
            InitializeComponent();
        }
        //form load-----
        private void frmTRAVAIL_Load(object sender, EventArgs e)
        {    
            data_load();
            remplissage();
        }
        //ajout---------------------------------------------------------------------------------
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TRAVAIL t = new TRAVAIL();
                t.CIN = comboBoxCIN.SelectedValue.ToString();
                t.CODE_PROFESSION =int.Parse(comboBoxPROFESSION.SelectedValue.ToString());
                t.DATE_TRAVAIL = dateTimePicker1.Value;
                t.DUREE = int.Parse(textBoxDUREE.Text);
                dc.TRAVAILs.InsertOnSubmit(t);
                dc.SubmitChanges();
                MessageBox.Show("Ajouter Avec Succes");
                data_load();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //modification-------------------------------

        //suppression -------------------------------

        // selection --------------------------------

        //recherche ---------------------------------
    }
}
