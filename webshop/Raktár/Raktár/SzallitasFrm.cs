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
    public partial class SzallitasFrm : Form
    {
        List<Rendeles> rLista;
        List<Futar> futarLista = ABKezelo.FutarLekerdez();
        Aru kijeloltAru;
        Vevo kijeloltVevo;
        Rendeles kijeloltRendeles;
        List<Szallitando> szLista;
       internal SzallitasFrm()
        {
            InitializeComponent();
            cmbCeg.DataSource=Enum.GetValues(typeof(FutarNevek));
            szLista = ABKezelo.SzallitandoLekerdez();
            rLista=new List<Rendeles>();
            if (dgwAdat.Columns.Count == 0)
            {
                dgwAdat.Columns.Add("tid", "Termék azonosítója");
                dgwAdat.Columns.Add("cikk", "Cikkszám");
                dgwAdat.Columns.Add("kat", "Kategória");
                dgwAdat.Columns.Add("tnev", "Termék neve");
                dgwAdat.Columns.Add("ardarab", "Ár/darab");
                dgwAdat.Columns.Add("darab", "Összes darabszám");
                dgwAdat.Columns.Add("rendaz", "Rendelési azonosító");
                dgwAdat.Columns.Add("renddb", "Rendelt darabszám");
                dgwAdat.Columns.Add("vid", "Vevőazonosító");
                dgwAdat.Columns.Add("ado", "Adószám(ha van)");
                dgwAdat.Columns.Add("vevonev", "Vevő neve");
                dgwAdat.Columns.Add("irsz", "Irányítószám");
                dgwAdat.Columns.Add("helyseg", "Település");
                dgwAdat.Columns.Add("utca", "Utca");
                dgwAdat.Columns.Add("hsz", "Házszám");
                dgwAdat.Columns.Add("tel", "Telefon");
                dgwAdat.Columns.Add("email", "E-mail");
            }
            foreach (Szallitando item in szLista)
            {
                Rendeles r = ABKezelo.RendelesBetolt().Where(x => x.Id == item.Rid).First();
                rLista.Add(r);
            }
            DgwFrissit();
        }

        void DgwFrissit()
        {
            dgwAdat.Rows.Clear();
            foreach (Rendeles item in rLista)
            {
                Aru a = ABKezelo.RendelesTermekLekerdez(item.Termekid);
                Vevo v = ABKezelo.RendelesVevoLekerdez(item.Vevoid);
                dgwAdat.Rows.Add(a.Id, a.Cikkszam, a.TermekKategoria, a.Nev, a.Darabar, a.Darab, item.Id, item.Darab, v.Id, v.Adoszam, v.Nev, v.Irsz, v.Helyseg, v.Utca, v.Hsz, v.Telefon, v.Email);
            }
        }

        private void Szallitas_Load(object sender, EventArgs e)
        {

        }

        private void cmbCeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCeg.SelectedItem)
            {
                case FutarNevek.GLS:
                    picFutar.BackgroundImage = new Bitmap("gls.jpg");
                    break;
                case FutarNevek.DPD:
                    picFutar.BackgroundImage = new Bitmap("dpd.jpg");
                    break;
                case FutarNevek.FOXPOST:
                    picFutar.BackgroundImage = new Bitmap("fox.png");
                    break;
            }
        }

        private void dgwAdat_Click(object sender, EventArgs e)
        {
            List<Futar> foxpost = futarLista.Where(x => x.Fnev == FutarNevek.FOXPOST).ToList();
            List<Futar> gls = futarLista.Where(x => x.Fnev == FutarNevek.GLS).ToList();
            List<Futar> dpd = futarLista.Where(x => x.Fnev == FutarNevek.DPD).ToList();
            if (dgwAdat.SelectedRows.Count != 0)
            {
                lbFutar.DataSource = null;
                DataGridViewRow adat = dgwAdat.SelectedRows[0];
                int rendid = Convert.ToInt32(adat.Cells[6].FormattedValue);
                int vevid = Convert.ToInt32(adat.Cells[8].FormattedValue);
                int termid = Convert.ToInt32(adat.Cells[0].FormattedValue);
                kijeloltAru = ABKezelo.RendelesTermekLekerdez(termid);
                kijeloltVevo = ABKezelo.RendelesVevoLekerdez(vevid);
                kijeloltRendeles = rLista.Where(x => x.Id == rendid).FirstOrDefault();
                if (kijeloltRendeles.Fnev == FutarNevek.FOXPOST)
                {
                    lbFutar.DataSource = foxpost;
                }
                else if (kijeloltRendeles.Fnev == FutarNevek.GLS)
                {
                    lbFutar.DataSource = gls;
                }
                else if (kijeloltRendeles.Fnev == FutarNevek.DPD)
                {
                    lbFutar.DataSource = dpd;
                }

            }
        }

        private void btnAtad_Click(object sender, EventArgs e)
        {
            if (lbFutar.SelectedIndex!=-1)
            {
                try
                {
                    int szallitasId = szLista.Where(x => x.Rid == kijeloltRendeles.Id).First().Id;
                    int futarId = (lbFutar.SelectedItem as Futar).Id;
                    ABKezelo.ElinditottHozzaad(szallitasId, futarId, kijeloltRendeles.Id);
                    MessageBox.Show("A rendelés sikeersen átadva a futár részére!");

                }
                catch (Exception)
                {

                    MessageBox.Show("A rendelés már futárnak át lett adva!");
                }
               
             
            }
        }

        private void btnFutarHozaad_Click(object sender, EventArgs e)
        {
            if (txtNev.Text!=""&&txtTelefon.Text!=""&&txtEmail.Text!="")
            {
                Futar f = new Futar(0, txtNev.Text, txtTelefon.Text, txtEmail.Text, (FutarNevek)cmbCeg.SelectedIndex);
                ABKezelo.FutarHozaad(f);
                futarLista = ABKezelo.FutarLekerdez();
                dgwAdat_Click(sender, e);
                MessageBox.Show("Sikeresen átadva");
            }
        }
    }
}
