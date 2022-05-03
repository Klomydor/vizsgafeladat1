namespace Raktár
{
    partial class SzerverFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSzerver = new System.Windows.Forms.TextBox();
            this.txtFelh = new System.Windows.Forms.TextBox();
            this.txtJel = new System.Windows.Forms.TextBox();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.btnMent = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szerver:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adatbázis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jelszó";
            // 
            // txtSzerver
            // 
            this.txtSzerver.Location = new System.Drawing.Point(125, 15);
            this.txtSzerver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSzerver.Name = "txtSzerver";
            this.txtSzerver.Size = new System.Drawing.Size(181, 22);
            this.txtSzerver.TabIndex = 4;
            // 
            // txtFelh
            // 
            this.txtFelh.Location = new System.Drawing.Point(125, 47);
            this.txtFelh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFelh.Name = "txtFelh";
            this.txtFelh.Size = new System.Drawing.Size(181, 22);
            this.txtFelh.TabIndex = 5;
            // 
            // txtJel
            // 
            this.txtJel.Location = new System.Drawing.Point(125, 82);
            this.txtJel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJel.Name = "txtJel";
            this.txtJel.Size = new System.Drawing.Size(181, 22);
            this.txtJel.TabIndex = 6;
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(125, 114);
            this.txtDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(181, 22);
            this.txtDb.TabIndex = 7;
            // 
            // btnMent
            // 
            this.btnMent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMent.Location = new System.Drawing.Point(16, 151);
            this.btnMent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMent.Name = "btnMent";
            this.btnMent.Size = new System.Drawing.Size(292, 28);
            this.btnMent.TabIndex = 8;
            this.btnMent.Text = "Mentés";
            this.btnMent.UseVisualStyleBackColor = true;
            this.btnMent.Click += new System.EventHandler(this.btnMent_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegse.Location = new System.Drawing.Point(16, 187);
            this.btnMegse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(292, 28);
            this.btnMegse.TabIndex = 9;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            // 
            // SzerverFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 268);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnMent);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.txtJel);
            this.Controls.Add(this.txtFelh);
            this.Controls.Add(this.txtSzerver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SzerverFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SzerverFrm";
            this.Load += new System.EventHandler(this.SzerverFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSzerver;
        private System.Windows.Forms.TextBox txtFelh;
        private System.Windows.Forms.TextBox txtJel;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Button btnMent;
        private System.Windows.Forms.Button btnMegse;
    }
}