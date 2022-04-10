using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Pesronnel
{
    public partial class frmAUTORISATION : MetroFramework.Forms.MetroForm
    {
        SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["chaine"].ConnectionString);
        DataSet ds = new DataSet();
        DataClasses1DataContext dc = new DataClasses1DataContext();
        string cin;
        public frmAUTORISATION(string code)
        {
            this.cin = code;
            InitializeComponent();
        }

        private void frmAUTORISATION_Load(object sender, EventArgs e)
        {
            //label1.Text = cin;
            //var q = from x in dc.CONGEs where x.CIN==cin select x;
            
            //advancedDataGridView1.DataSource = q;
            SqlDataAdapter da = new SqlDataAdapter("select top(1) * from vconge  where cin='" + cin + "'  order by date_conge desc", cnx);
            ds.Clear();
            da.Fill(ds, "vconge");
            CrystalReport1 r = new CrystalReport1();
            r.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = r;

                                                                                                                                  
        }
    }
}
