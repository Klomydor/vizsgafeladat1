using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Raktár
{
    public partial class FomenuFrm : Form
    {
        public FomenuFrm()
        {
            InitializeComponent();
        }

        private void btnTermek_Click(object sender, EventArgs e)
        {
            TermekFrm t = new TermekFrm();
            t.ShowDialog();
        }

        private void btnRendeles_Click(object sender, EventArgs e)
        {
            RendelesFrm diag=new RendelesFrm();
            diag.ShowDialog();
        }

        private void szerverBeállításaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SzerverFrm diag=new SzerverFrm();
            diag.ShowDialog();
        }

        private void FomenuFrm_Load(object sender, EventArgs e)
        {
            Fajlkezelo.BeallitasBetolt();
        }

        private void gyökérkönyvtárMegadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                string hely = "";
                for (int i = 0; i < fbd.SelectedPath.Length; i++)
                {
                    if (fbd.SelectedPath[i] == '\\')
                    {
                        hely += fbd.SelectedPath[i];
                        hely += "\\";

                    }
                    else
                    {
                        hely += fbd.SelectedPath[i];
                    }
                }
                Interaction.InputBox("A weboldal alapkönyvtárának a helye:", fbd.SelectedPath, hely);
                Fajlkezelo.BeallitasMent(hely);
            }
        }

        private void btnSzallitas_Click(object sender, EventArgs e)
        {
            ElinditottFrm diag=new ElinditottFrm();
            diag.ShowDialog();
        }
    }
}
