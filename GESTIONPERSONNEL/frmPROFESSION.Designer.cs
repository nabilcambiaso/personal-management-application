namespace GESTIONPERSONNEL
{
    partial class frmPROFESSION
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPRIME = new System.Windows.Forms.TextBox();
            this.textBoxSALAIRE = new System.Windows.Forms.TextBox();
            this.textBoxINTITULE = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxCODE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(674, 240);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(247, 30);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Supprimer Profession";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(421, 240);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(247, 30);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Modifier Profession";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(168, 240);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(247, 30);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Ajouter Profession";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.advancedDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(23, 276);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1093, 430);
            this.advancedDataGridView1.TabIndex = 8;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SelectionChanged += new System.EventHandler(this.advancedDataGridView1_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 460;
            this.label4.Text = "Prime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 470;
            this.label3.Text = "Salaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 471;
            this.label2.Text = "Intitulé";
            // 
            // textBoxPRIME
            // 
            this.textBoxPRIME.Location = new System.Drawing.Point(355, 156);
            this.textBoxPRIME.Name = "textBoxPRIME";
            this.textBoxPRIME.Size = new System.Drawing.Size(271, 20);
            this.textBoxPRIME.TabIndex = 3;
            // 
            // textBoxSALAIRE
            // 
            this.textBoxSALAIRE.Location = new System.Drawing.Point(355, 130);
            this.textBoxSALAIRE.Name = "textBoxSALAIRE";
            this.textBoxSALAIRE.Size = new System.Drawing.Size(271, 20);
            this.textBoxSALAIRE.TabIndex = 2;
            // 
            // textBoxINTITULE
            // 
            this.textBoxINTITULE.Location = new System.Drawing.Point(355, 104);
            this.textBoxINTITULE.Name = "textBoxINTITULE";
            this.textBoxINTITULE.Size = new System.Drawing.Size(271, 20);
            this.textBoxINTITULE.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(233, 27);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(393, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxCODE
            // 
            this.textBoxCODE.Enabled = false;
            this.textBoxCODE.Location = new System.Drawing.Point(355, 78);
            this.textBoxCODE.Name = "textBoxCODE";
            this.textBoxCODE.Size = new System.Drawing.Size(49, 20);
            this.textBoxCODE.TabIndex = 472;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 471;
            this.label1.Text = "Code";
            // 
            // frmPROFESSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 717);
            this.Controls.Add(this.textBoxCODE);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPRIME);
            this.Controls.Add(this.textBoxSALAIRE);
            this.Controls.Add(this.textBoxINTITULE);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "frmPROFESSION";
            this.Text = "frmPROFESSION";
            this.Load += new System.EventHandler(this.frmPROFESSION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPRIME;
        private System.Windows.Forms.TextBox textBoxSALAIRE;
        private System.Windows.Forms.TextBox textBoxINTITULE;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxCODE;
        private System.Windows.Forms.Label label1;
    }
}