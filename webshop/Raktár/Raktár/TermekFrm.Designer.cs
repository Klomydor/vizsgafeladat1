namespace Raktár
{
    partial class TermekFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFeltolt = new System.Windows.Forms.Button();
            this.btnKep = new System.Windows.Forms.Button();
            this.numDarab = new System.Windows.Forms.NumericUpDown();
            this.txtDarabar = new System.Windows.Forms.TextBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.cmbKategoria = new System.Windows.Forms.ComboBox();
            this.txtCikkszam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctKep = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTermekModosit = new System.Windows.Forms.Button();
            this.pctKepModosit = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnKepTorol = new System.Windows.Forms.Button();
            this.btnKepModosit = new System.Windows.Forms.Button();
            this.numDarabModosit = new System.Windows.Forms.NumericUpDown();
            this.txtDarabarModosit = new System.Windows.Forms.TextBox();
            this.txtNevModosit = new System.Windows.Forms.TextBox();
            this.cmbKategoriaModosit = new System.Windows.Forms.ComboBox();
            this.txtCikkModosit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgwAdat = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDarab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKep)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctKepModosit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDarabModosit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnFeltolt);
            this.groupBox1.Controls.Add(this.btnKep);
            this.groupBox1.Controls.Add(this.numDarab);
            this.groupBox1.Controls.Add(this.txtDarabar);
            this.groupBox1.Controls.Add(this.txtNev);
            this.groupBox1.Controls.Add(this.cmbKategoria);
            this.groupBox1.Controls.Add(this.txtCikkszam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új termék rögzítése";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Miriam Libre", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(612, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 70);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tekerj\r\nKerékpárüzlet";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFeltolt
            // 
            this.btnFeltolt.Location = new System.Drawing.Point(21, 206);
            this.btnFeltolt.Name = "btnFeltolt";
            this.btnFeltolt.Size = new System.Drawing.Size(233, 23);
            this.btnFeltolt.TabIndex = 12;
            this.btnFeltolt.Text = "Feltöltés az adatbázisba";
            this.btnFeltolt.UseVisualStyleBackColor = true;
            this.btnFeltolt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKep
            // 
            this.btnKep.Location = new System.Drawing.Point(21, 177);
            this.btnKep.Name = "btnKep";
            this.btnKep.Size = new System.Drawing.Size(233, 23);
            this.btnKep.TabIndex = 11;
            this.btnKep.Text = "Kép hozzáadása";
            this.btnKep.UseVisualStyleBackColor = true;
            this.btnKep.Click += new System.EventHandler(this.btnKep_Click);
            // 
            // numDarab
            // 
            this.numDarab.Location = new System.Drawing.Point(87, 151);
            this.numDarab.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numDarab.Name = "numDarab";
            this.numDarab.Size = new System.Drawing.Size(167, 20);
            this.numDarab.TabIndex = 10;
            // 
            // txtDarabar
            // 
            this.txtDarabar.Location = new System.Drawing.Point(87, 120);
            this.txtDarabar.MaxLength = 6;
            this.txtDarabar.Name = "txtDarabar";
            this.txtDarabar.Size = new System.Drawing.Size(167, 20);
            this.txtDarabar.TabIndex = 9;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(87, 93);
            this.txtNev.MaxLength = 50;
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(167, 20);
            this.txtNev.TabIndex = 8;
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.FormattingEnabled = true;
            this.cmbKategoria.Location = new System.Drawing.Point(87, 64);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(167, 21);
            this.cmbKategoria.TabIndex = 7;
            // 
            // txtCikkszam
            // 
            this.txtCikkszam.Location = new System.Drawing.Point(87, 36);
            this.txtCikkszam.MaxLength = 6;
            this.txtCikkszam.Name = "txtCikkszam";
            this.txtCikkszam.Size = new System.Drawing.Size(167, 20);
            this.txtCikkszam.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Darab";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Darabár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategória";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cikkszám";
            // 
            // pctKep
            // 
            this.pctKep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctKep.Location = new System.Drawing.Point(282, 45);
            this.pctKep.Name = "pctKep";
            this.pctKep.Size = new System.Drawing.Size(221, 196);
            this.pctKep.TabIndex = 12;
            this.pctKep.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnTermekModosit);
            this.groupBox2.Controls.Add(this.pctKepModosit);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.btnTorol);
            this.groupBox2.Controls.Add(this.btnKepTorol);
            this.groupBox2.Controls.Add(this.btnKepModosit);
            this.groupBox2.Controls.Add(this.numDarabModosit);
            this.groupBox2.Controls.Add(this.txtDarabarModosit);
            this.groupBox2.Controls.Add(this.txtNevModosit);
            this.groupBox2.Controls.Add(this.cmbKategoriaModosit);
            this.groupBox2.Controls.Add(this.txtCikkModosit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dgwAdat);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 504);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termék szerkesztése";
            // 
            // btnTermekModosit
            // 
            this.btnTermekModosit.Location = new System.Drawing.Point(668, 244);
            this.btnTermekModosit.Name = "btnTermekModosit";
            this.btnTermekModosit.Size = new System.Drawing.Size(233, 23);
            this.btnTermekModosit.TabIndex = 25;
            this.btnTermekModosit.Text = "Termék Módosítása";
            this.btnTermekModosit.UseVisualStyleBackColor = true;
            this.btnTermekModosit.Click += new System.EventHandler(this.btnTermekModosit_Click);
            // 
            // pctKepModosit
            // 
            this.pctKepModosit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctKepModosit.Location = new System.Drawing.Point(671, 284);
            this.pctKepModosit.Name = "pctKepModosit";
            this.pctKepModosit.Size = new System.Drawing.Size(230, 197);
            this.pctKepModosit.TabIndex = 14;
            this.pctKepModosit.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(679, 268);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 13);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "Termék ID:";
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(668, 215);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(233, 23);
            this.btnTorol.TabIndex = 23;
            this.btnTorol.Text = "Termék törlése";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnKepTorol
            // 
            this.btnKepTorol.Location = new System.Drawing.Point(668, 186);
            this.btnKepTorol.Name = "btnKepTorol";
            this.btnKepTorol.Size = new System.Drawing.Size(233, 23);
            this.btnKepTorol.TabIndex = 22;
            this.btnKepTorol.Text = "Kép Törlése";
            this.btnKepTorol.UseVisualStyleBackColor = true;
            this.btnKepTorol.Click += new System.EventHandler(this.btnKepTorol_Click);
            // 
            // btnKepModosit
            // 
            this.btnKepModosit.Location = new System.Drawing.Point(668, 157);
            this.btnKepModosit.Name = "btnKepModosit";
            this.btnKepModosit.Size = new System.Drawing.Size(233, 23);
            this.btnKepModosit.TabIndex = 21;
            this.btnKepModosit.Text = "Kép Módosítása";
            this.btnKepModosit.UseVisualStyleBackColor = true;
            this.btnKepModosit.Click += new System.EventHandler(this.btnKepModosit_Click);
            // 
            // numDarabModosit
            // 
            this.numDarabModosit.Location = new System.Drawing.Point(737, 131);
            this.numDarabModosit.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numDarabModosit.Name = "numDarabModosit";
            this.numDarabModosit.Size = new System.Drawing.Size(167, 20);
            this.numDarabModosit.TabIndex = 20;
            // 
            // txtDarabarModosit
            // 
            this.txtDarabarModosit.Location = new System.Drawing.Point(737, 100);
            this.txtDarabarModosit.MaxLength = 6;
            this.txtDarabarModosit.Name = "txtDarabarModosit";
            this.txtDarabarModosit.Size = new System.Drawing.Size(167, 20);
            this.txtDarabarModosit.TabIndex = 19;
            // 
            // txtNevModosit
            // 
            this.txtNevModosit.Location = new System.Drawing.Point(737, 73);
            this.txtNevModosit.MaxLength = 50;
            this.txtNevModosit.Name = "txtNevModosit";
            this.txtNevModosit.Size = new System.Drawing.Size(167, 20);
            this.txtNevModosit.TabIndex = 18;
            // 
            // cmbKategoriaModosit
            // 
            this.cmbKategoriaModosit.FormattingEnabled = true;
            this.cmbKategoriaModosit.Location = new System.Drawing.Point(737, 44);
            this.cmbKategoriaModosit.Name = "cmbKategoriaModosit";
            this.cmbKategoriaModosit.Size = new System.Drawing.Size(167, 21);
            this.cmbKategoriaModosit.TabIndex = 17;
            // 
            // txtCikkModosit
            // 
            this.txtCikkModosit.Location = new System.Drawing.Point(737, 16);
            this.txtCikkModosit.MaxLength = 6;
            this.txtCikkModosit.Name = "txtCikkModosit";
            this.txtCikkModosit.Size = new System.Drawing.Size(167, 20);
            this.txtCikkModosit.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Darab";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Darabár";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Név";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Kategória";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(668, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cikkszám";
            // 
            // dgwAdat
            // 
            this.dgwAdat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwAdat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdat.Location = new System.Drawing.Point(6, 19);
            this.dgwAdat.Name = "dgwAdat";
            this.dgwAdat.Size = new System.Drawing.Size(630, 462);
            this.dgwAdat.TabIndex = 0;
            this.dgwAdat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdat_CellContentClick);
            this.dgwAdat.Click += new System.EventHandler(this.dgwAdat_Click);
            // 
            // Termek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 792);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pctKep);
            this.Controls.Add(this.groupBox1);
            this.Name = "Termek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termek";
            this.Load += new System.EventHandler(this.Termek_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDarab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctKepModosit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDarabModosit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategoria;
        private System.Windows.Forms.TextBox txtCikkszam;
        private System.Windows.Forms.PictureBox pctKep;
        private System.Windows.Forms.Button btnKep;
        private System.Windows.Forms.NumericUpDown numDarab;
        private System.Windows.Forms.TextBox txtDarabar;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Button btnFeltolt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwAdat;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnKepTorol;
        private System.Windows.Forms.Button btnKepModosit;
        private System.Windows.Forms.NumericUpDown numDarabModosit;
        private System.Windows.Forms.TextBox txtDarabarModosit;
        private System.Windows.Forms.TextBox txtNevModosit;
        private System.Windows.Forms.ComboBox cmbKategoriaModosit;
        private System.Windows.Forms.TextBox txtCikkModosit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pctKepModosit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTermekModosit;
    }
}