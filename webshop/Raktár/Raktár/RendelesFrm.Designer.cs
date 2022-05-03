namespace Raktár
{
    partial class RendelesFrm
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
            this.dgwRendelesek = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frissítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállításraKijelöltTételekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBuzenet = new System.Windows.Forms.TextBox();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnSzamlakeszit = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnSzallitas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRendelesek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgwRendelesek);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beérkezett rendelések";
            // 
            // dgwRendelesek
            // 
            this.dgwRendelesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRendelesek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRendelesek.Location = new System.Drawing.Point(3, 16);
            this.dgwRendelesek.Name = "dgwRendelesek";
            this.dgwRendelesek.Size = new System.Drawing.Size(944, 392);
            this.dgwRendelesek.TabIndex = 0;
            this.dgwRendelesek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRendelesek_CellContentClick);
            this.dgwRendelesek.Click += new System.EventHandler(this.dgwRendelesek_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezelésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kezelésToolStripMenuItem
            // 
            this.kezelésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frissítésToolStripMenuItem,
            this.szállításraKijelöltTételekToolStripMenuItem});
            this.kezelésToolStripMenuItem.Name = "kezelésToolStripMenuItem";
            this.kezelésToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kezelésToolStripMenuItem.Text = "Kezelés";
            // 
            // frissítésToolStripMenuItem
            // 
            this.frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            this.frissítésToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.frissítésToolStripMenuItem.Text = "Frissítés";
            this.frissítésToolStripMenuItem.Click += new System.EventHandler(this.frissítésToolStripMenuItem_Click);
            // 
            // szállításraKijelöltTételekToolStripMenuItem
            // 
            this.szállításraKijelöltTételekToolStripMenuItem.Name = "szállításraKijelöltTételekToolStripMenuItem";
            this.szállításraKijelöltTételekToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.szállításraKijelöltTételekToolStripMenuItem.Text = "Szállításra kijelölt tételek";
            this.szállításraKijelöltTételekToolStripMenuItem.Click += new System.EventHandler(this.szállításraKijelöltTételekToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDBuzenet);
            this.groupBox2.Controls.Add(this.btnBezar);
            this.groupBox2.Controls.Add(this.btnSzamlakeszit);
            this.groupBox2.Controls.Add(this.btnTorol);
            this.groupBox2.Controls.Add(this.btnSzallitas);
            this.groupBox2.Location = new System.Drawing.Point(965, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 408);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adatbázis üzenetei";
            // 
            // txtDBuzenet
            // 
            this.txtDBuzenet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDBuzenet.Location = new System.Drawing.Point(6, 183);
            this.txtDBuzenet.Multiline = true;
            this.txtDBuzenet.Name = "txtDBuzenet";
            this.txtDBuzenet.Size = new System.Drawing.Size(211, 219);
            this.txtDBuzenet.TabIndex = 5;
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(6, 127);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(211, 30);
            this.btnBezar.TabIndex = 4;
            this.btnBezar.Text = "Bezárás";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnSzamlakeszit
            // 
            this.btnSzamlakeszit.Location = new System.Drawing.Point(6, 91);
            this.btnSzamlakeszit.Name = "btnSzamlakeszit";
            this.btnSzamlakeszit.Size = new System.Drawing.Size(211, 30);
            this.btnSzamlakeszit.TabIndex = 3;
            this.btnSzamlakeszit.Text = "Számla készítése";
            this.btnSzamlakeszit.UseVisualStyleBackColor = true;
            this.btnSzamlakeszit.Click += new System.EventHandler(this.btnSzamlakeszit_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(6, 55);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(211, 30);
            this.btnTorol.TabIndex = 2;
            this.btnTorol.Text = "Rendelés törlése";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnSzallitas
            // 
            this.btnSzallitas.Location = new System.Drawing.Point(6, 19);
            this.btnSzallitas.Name = "btnSzallitas";
            this.btnSzallitas.Size = new System.Drawing.Size(211, 30);
            this.btnSzallitas.TabIndex = 0;
            this.btnSzallitas.Text = "Szállításra kijelöl";
            this.btnSzallitas.UseVisualStyleBackColor = true;
            this.btnSzallitas.Click += new System.EventHandler(this.btnSzallitas_Click);
            // 
            // RendelesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RendelesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szallitas";
            this.Load += new System.EventHandler(this.SzallitasFrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRendelesek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwRendelesek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kezelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frissítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállításraKijelöltTételekToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Button btnSzamlakeszit;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnSzallitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDBuzenet;
    }
}