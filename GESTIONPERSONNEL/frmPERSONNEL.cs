using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADGV;
using System.IO;
namespace GESTIONPERSONNEL
{
    public partial class frmPERSONNEL : MetroFramework.Forms.MetroForm
    {

        DataClasses1DataContext dc = new DataClasses1DataContext();
        static string nom = "";
        //functions --------------------------------------------------------------------------------------------------------------
        public void data_load()
        {
            try
            {
                var q = from x in dc.PERSONNELs
                        select new
                        {
                            code_didentite_national = x.CIN,
                            x.NOM,
                            x.PRENOM,
                            x.ADRESSE,
                            numero_de_telephone = x.NUMTEL,
                            image_Name=x.image
                        };
                advancedDataGridView1.DataSource = q.ToList();
            }
            catch { }
        }
        public void clearit()
        {
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
            txtBox4.Clear();
            txtBox5.Clear();
        }

        //methodes-----------------------------------------------------------------------------------------------------------------
        public frmPERSONNEL()
        {
            InitializeComponent();
        }
     
        private void frmPERSONNEL_Load(object sender, EventArgs e)
        {   
            data_load();   
        }
        //ajout-------------------------------------------------------------------------------------------------------------------
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string ch = txtBox1.Text+"."+nom.Substring(nom.Length - 3,3);
                PERSONNEL p = new PERSONNEL();
                p.CIN=txtBox1.Text;
                p.NOM=txtBox2.Text;
                p.PRENOM=txtBox3.Text;
                p.ADRESSE= txtBox4.Text;
                p.NUMTEL=int.Parse(txtBox5.Text);
                MessageBox.Show(ch);
                p.image = ch;
                File.Copy(textBox2.Text, Application.StartupPath+@"\images\"+ch);
                dc.PERSONNELs.InsertOnSubmit(p);
                dc.SubmitChanges();
                data_load();
                MessageBox.Show("Ajouter Avec Succes");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         

        }
        //modification--------------------------------------------------------------------------------------------------------------
        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var q = (from x in dc.PERSONNELs where x.CIN == txtBox1.Text.ToString() select x).Single();
                q.NOM = txtBox2.Text;
                q.PRENOM = txtBox3.Text;
                q.ADRESSE = txtBox4.Text;
                q.NUMTEL = int.Parse(txtBox5.Text);
                dc.SubmitChanges();
                MessageBox.Show("modification effectué");
                data_load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //search-------------------------------------------------------------------------------------------------------------------

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var q = (from x in dc.PERSONNELs where x.CIN.StartsWith(textBoxSearch.Text.ToString()) select x).Single();
                clearit();
                txtBox1.Text = q.CIN;
                txtBox2.Text = q.NOM;
                txtBox3.Text = q.PRENOM;
                txtBox4.Text = q.ADRESSE;
                txtBox5.Text = q.NUMTEL.ToString();
            }
            catch { }
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //selection-------------------------------------------------------------------------------------------------------------------

        private void advancedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtBox1.Text = advancedDataGridView1.Rows[advancedDataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtBox2.Text = advancedDataGridView1.Rows[advancedDataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtBox3.Text = advancedDataGridView1.Rows[advancedDataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtBox4.Text = advancedDataGridView1.Rows[advancedDataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                txtBox5.Text = advancedDataGridView1.Rows[advancedDataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\images\" + advancedDataGridView1.Rows[advancedDataGridView1.CurrentRow.Index].Cells[5].Value.ToString());
        
            }
            catch
            {

            }
        }
        //sUPPRESSION-------------------------------------------------------------------------------------------------------------------
        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("voulez-vous supprimez ?","suppression",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var q = (from x in dc.PERSONNELs where x.CIN  == txtBox1.Text  select x).Single();
                    dc.PERSONNELs.DeleteOnSubmit(q);
                    dc.SubmitChanges();
                    MessageBox.Show("suppression effectué");
                    data_load();
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {    
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
            try
            {
                
               // s.Filter = ("jpg files|*.jpg | png files| *.png");
                s.Title = "Choisir votre image";              
                s.FileName = "";
                s.ShowDialog();
                this.pictureBox1.Image = Image.FromFile(s.FileName);
                textBox2.Text = s.FileName;
                nom = s.SafeFileName;
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



    }
}
