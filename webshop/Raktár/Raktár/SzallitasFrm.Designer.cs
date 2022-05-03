namespace Raktár
{
    partial class SzallitasFrm
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
            this.dgwAdat = new System.Windows.Forms.DataGridView();
            this.lbFutar = new System.Windows.Forms.ListBox();
            this.picFutar = new System.Windows.Forms.PictureBox();
            this.btnAtad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFutarHozaad = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbCeg = new System.Windows.Forms.ComboBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFutar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAdat
            // 
            this.dgwAdat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdat.Location = new System.Drawing.Point(12, 12);
            this.dgwAdat.Name = "dgwAdat";
            this.dgwAdat.Size = new System.Drawing.Size(776, 277);
            this.dgwAdat.TabIndex = 0;
            this.dgwAdat.Click += new System.EventHandler(this.dgwAdat_Click);
            // 
            // lbFutar
            // 
            this.lbFutar.FormattingEnabled = true;
            this.lbFutar.Location = new System.Drawing.Point(12, 295);
            this.lbFutar.Name = "lbFutar";
            this.lbFutar.Size = new System.Drawing.Size(290, 290);
            this.lbFutar.TabIndex = 1;
            // 
            // picFutar
            // 
            this.picFutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFutar.Location = new System.Drawing.Point(298, 155);
            this.picFutar.Name = "picFutar";
            this.picFutar.Size = new System.Drawing.Size(176, 163);
            this.picFutar.TabIndex = 2;
            this.picFutar.TabStop = false;
            // 
            // btnAtad
            // 
            this.btnAtad.Location = new System.Drawing.Point(12, 600);
            this.btnAtad.Name = "btnAtad";
            this.btnAtad.Size = new System.Drawing.Size(290, 24);
            this.btnAtad.TabIndex = 3;
            this.btnAtad.Text = "Átadás a futárnak";
            this.btnAtad.UseVisualStyleBackColor = true;
            this.btnAtad.Click += new System.EventHandler(this.btnAtad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFutarHozaad);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.cmbCeg);
            this.groupBox1.Controls.Add(this.txtNev);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.picFutar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(308, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 329);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Futárok szerkesztése";
            // 
            // btnFutarHozaad
            // 
            this.btnFutarHozaad.Location = new System.Drawing.Point(106, 155);
            this.btnFutarHozaad.Name = "btnFutarHozaad";
            this.btnFutarHozaad.Size = new System.Drawing.Size(175, 25);
            this.btnFutarHozaad.TabIndex = 8;
            this.btnFutarHozaad.Text = "Futár hozzáadása";
            this.btnFutarHozaad.UseVisualStyleBackColor = true;
            this.btnFutarHozaad.Click += new System.EventHandler(this.btnFutarHozaad_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(106, 93);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(368, 20);
            this.txtTelefon.TabIndex = 6;
            // 
            // cmbCeg
            // 
            this.cmbCeg.FormattingEnabled = true;
            this.cmbCeg.Location = new System.Drawing.Point(106, 59);
            this.cmbCeg.Name = "cmbCeg";
            this.cmbCeg.Size = new System.Drawing.Size(368, 21);
            this.cmbCeg.TabIndex = 5;
            this.cmbCeg.SelectedIndexChanged += new System.EventHandler(this.cmbCeg_SelectedIndexChanged);
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(106, 24);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(368, 20);
            this.txtNev.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szállító cég";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // SzallitasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtad);
            this.Controls.Add(this.lbFutar);
            this.Controls.Add(this.dgwAdat);
            this.Name = "SzallitasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szallitas";
            this.Load += new System.EventHandler(this.Szallitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFutar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAdat;
        private System.Windows.Forms.ListBox lbFutar;
        private System.Windows.Forms.PictureBox picFutar;
        private System.Windows.Forms.Button btnAtad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbCeg;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFutarHozaad;
    }
}