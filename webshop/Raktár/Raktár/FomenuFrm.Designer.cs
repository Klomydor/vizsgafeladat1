namespace Raktár
{
    partial class FomenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FomenuFrm));
            this.btnTermek = new System.Windows.Forms.Button();
            this.btnRendeles = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerverBeállításaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyökérkönyvtárMegadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSzallitas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTermek
            // 
            this.btnTermek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTermek.BackgroundImage")));
            this.btnTermek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTermek.Location = new System.Drawing.Point(12, 39);
            this.btnTermek.Name = "btnTermek";
            this.btnTermek.Size = new System.Drawing.Size(152, 141);
            this.btnTermek.TabIndex = 0;
            this.btnTermek.Text = "Termékek kezelése";
            this.btnTermek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTermek.UseVisualStyleBackColor = true;
            this.btnTermek.Click += new System.EventHandler(this.btnTermek_Click);
            // 
            // btnRendeles
            // 
            this.btnRendeles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRendeles.BackgroundImage")));
            this.btnRendeles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRendeles.Location = new System.Drawing.Point(170, 39);
            this.btnRendeles.Name = "btnRendeles";
            this.btnRendeles.Size = new System.Drawing.Size(152, 141);
            this.btnRendeles.TabIndex = 2;
            this.btnRendeles.Text = "Rendelések";
            this.btnRendeles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRendeles.UseVisualStyleBackColor = true;
            this.btnRendeles.Click += new System.EventHandler(this.btnRendeles_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállításokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerverBeállításaiToolStripMenuItem,
            this.gyökérkönyvtárMegadásaToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // szerverBeállításaiToolStripMenuItem
            // 
            this.szerverBeállításaiToolStripMenuItem.Name = "szerverBeállításaiToolStripMenuItem";
            this.szerverBeállításaiToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.szerverBeállításaiToolStripMenuItem.Text = "Szerver beállításai";
            this.szerverBeállításaiToolStripMenuItem.Click += new System.EventHandler(this.szerverBeállításaiToolStripMenuItem_Click);
            // 
            // gyökérkönyvtárMegadásaToolStripMenuItem
            // 
            this.gyökérkönyvtárMegadásaToolStripMenuItem.Name = "gyökérkönyvtárMegadásaToolStripMenuItem";
            this.gyökérkönyvtárMegadásaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.gyökérkönyvtárMegadásaToolStripMenuItem.Text = "Gyökérkönyvtár megadása";
            this.gyökérkönyvtárMegadásaToolStripMenuItem.Click += new System.EventHandler(this.gyökérkönyvtárMegadásaToolStripMenuItem_Click);
            // 
            // btnSzallitas
            // 
            this.btnSzallitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSzallitas.BackgroundImage")));
            this.btnSzallitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSzallitas.Location = new System.Drawing.Point(328, 39);
            this.btnSzallitas.Name = "btnSzallitas";
            this.btnSzallitas.Size = new System.Drawing.Size(152, 141);
            this.btnSzallitas.TabIndex = 4;
            this.btnSzallitas.Text = "Elindított kiszállítások";
            this.btnSzallitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSzallitas.UseVisualStyleBackColor = true;
            this.btnSzallitas.Click += new System.EventHandler(this.btnSzallitas_Click);
            // 
            // FomenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 192);
            this.Controls.Add(this.btnSzallitas);
            this.Controls.Add(this.btnRendeles);
            this.Controls.Add(this.btnTermek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FomenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktárkezelő";
            this.Load += new System.EventHandler(this.FomenuFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTermek;
        private System.Windows.Forms.Button btnRendeles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerverBeállításaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyökérkönyvtárMegadásaToolStripMenuItem;
        private System.Windows.Forms.Button btnSzallitas;
    }
}