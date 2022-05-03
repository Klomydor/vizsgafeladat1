namespace Raktár
{
    partial class ElinditottFrm
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
            this.lbElinditott = new System.Windows.Forms.ListBox();
            this.btnSzallitasOk = new System.Windows.Forms.Button();
            this.btnSzallitasNemOk = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbElinditott
            // 
            this.lbElinditott.FormattingEnabled = true;
            this.lbElinditott.HorizontalScrollbar = true;
            this.lbElinditott.Location = new System.Drawing.Point(2, 3);
            this.lbElinditott.Name = "lbElinditott";
            this.lbElinditott.ScrollAlwaysVisible = true;
            this.lbElinditott.Size = new System.Drawing.Size(1019, 381);
            this.lbElinditott.TabIndex = 0;
            this.lbElinditott.SelectedIndexChanged += new System.EventHandler(this.lbElinditott_SelectedIndexChanged);
            // 
            // btnSzallitasOk
            // 
            this.btnSzallitasOk.Location = new System.Drawing.Point(2, 399);
            this.btnSzallitasOk.Name = "btnSzallitasOk";
            this.btnSzallitasOk.Size = new System.Drawing.Size(140, 23);
            this.btnSzallitasOk.TabIndex = 1;
            this.btnSzallitasOk.Text = "Szállítás teljesült";
            this.btnSzallitasOk.UseVisualStyleBackColor = true;
            this.btnSzallitasOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSzallitasNemOk
            // 
            this.btnSzallitasNemOk.Location = new System.Drawing.Point(148, 399);
            this.btnSzallitasNemOk.Name = "btnSzallitasNemOk";
            this.btnSzallitasNemOk.Size = new System.Drawing.Size(140, 23);
            this.btnSzallitasNemOk.TabIndex = 2;
            this.btnSzallitasNemOk.Text = "Szállítás nem teljesült";
            this.btnSzallitasNemOk.UseVisualStyleBackColor = true;
            this.btnSzallitasNemOk.Click += new System.EventHandler(this.btnSzallitasNemOk_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegse.Location = new System.Drawing.Point(294, 399);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(140, 23);
            this.btnMegse.TabIndex = 3;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            // 
            // ElinditottFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 437);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnSzallitasNemOk);
            this.Controls.Add(this.btnSzallitasOk);
            this.Controls.Add(this.lbElinditott);
            this.Name = "ElinditottFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElinditottFrm";
            this.Load += new System.EventHandler(this.ElinditottFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbElinditott;
        private System.Windows.Forms.Button btnSzallitasOk;
        private System.Windows.Forms.Button btnSzallitasNemOk;
        private System.Windows.Forms.Button btnMegse;
    }
}