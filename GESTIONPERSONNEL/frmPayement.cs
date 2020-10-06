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
    public partial class frmPayement : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public frmPayement()
        {
            InitializeComponent();
        }

        private void frmPayement_Load(object sender, EventArgs e)
        {
            try
            {
                var q = from pers in dc.PERSONNELs
                        join travail in dc.TRAVAILs on pers.CIN equals travail.CIN
                        join profession in dc.PROFESSIONs on travail.CODE_PROFESSION equals profession.CODE_PROFESSION
                        select new
                        {
                            CIN = pers.CIN,
                            Nom = pers.NOM,
                            Prenom = pers.PRENOM,
                            Profession = profession.INTITULE,
                            Salaire_Net = profession.SALAIRE + profession.PRIME,
                            Numero_de_telephone = pers.NUMTEL
                        };
                advancedDataGridView1.DataSource = q.ToList();
            }
            catch { }
       
        }
    }
}
