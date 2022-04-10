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
    public partial class frmACCEUIL : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public string cin;

        public void addList()
        {
            listBox1.Items.Clear();
            var q = from x in dc.CONGEs where x.CIN == cin select x;
            int pos=1;
            if (q !=null)
            {
                foreach (CONGE item in q)
                {
                    listBox1.Items.Add("congé : " + pos + " le : " + item.DATE_CONGE + " | Durée : " + item.DUREE + " Jours | date de fin : " + item.DATE_CONGE.AddDays(int.Parse(item.DUREE.ToString())) + " | etat : " + item.ETAT);
                }
            }
           
        }


        public frmACCEUIL(string cin)
        {
            this.cin = cin;
            InitializeComponent();
        }

        private void frmACCEUIL_Load(object sender, EventArgs e)
        {
            try
            {
                var q = (from x in dc.CONGEs where x.ETAT.Equals("EN COURS") && x.CIN.Equals(cin) select x).Single();
                if (q != null)
                {
                    button2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

            textBox1.Text = cin;
            try
            {
                addList();
            }
            catch { }
        }

        private void frmACCEUIL_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //foreach(CONGE item in dc.CONGEs)
                //{
                //    if(item.CIN==cin)
                //    {
                //        if(item.ETAT=="EN COURS")
                //        {
                //            MessageBox.Show("impossible car vous avez un conge en cours !!");
                //        }
                //        else 
                //        {
                            if (MessageBox.Show("valider le congé ?", " validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                CONGE g = new CONGE();
                                g.DATE_CONGE = dateTimePicker1.Value;
                                g.CIN = textBox1.Text;
                                g.DUREE = int.Parse(textBox2.Text);
                                g.ETAT = "EN ATTENTE";
                                dc.CONGEs.InsertOnSubmit(g);
                                dc.SubmitChanges();
                                addList();
                            }
                    //    }
                    //}
                 
                //}
               
            }
            catch(Exception ex)
            {

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                    frmAUTORISATION f = new frmAUTORISATION(cin);
                    f.ShowDialog();
           
           
        }
    }
}
