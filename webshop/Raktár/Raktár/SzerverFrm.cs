using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raktár
{
    public partial class SzerverFrm : Form
    {
        public SzerverFrm()
        {
            InitializeComponent();
        }

        private void btnMent_Click(object sender, EventArgs e)
        {
            if (txtSzerver.Text!=""&&txtFelh.Text!=""&&txtDb.Text!="")
            {
                Beallitas.szerver = txtSzerver.Text;
                Beallitas.felh = txtFelh.Text;
                Beallitas.jel = txtJel.Text;
                Beallitas.db = txtDb.Text;

                Fajlkezelo.BeallitasMent(Beallitas.htmlMappa);
            }
        }

        private void SzerverFrm_Load(object sender, EventArgs e)
        {
            txtSzerver.Text = Beallitas.szerver;
            txtFelh.Text = Beallitas.felh;
            txtJel.Text = Beallitas.jel;
            txtDb.Text = Beallitas.db;
        }
    }
}
