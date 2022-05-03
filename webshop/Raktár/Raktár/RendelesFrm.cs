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
    public partial class RendelesFrm : Form
    {
        List<Rendeles> rLista = ABKezelo.RendelesBetolt();
        Rendeles kijeloltRendeles;
        Vevo kijeloltVevo;
        Aru kijeloltAru;
        int kijelolsor=0;
        List<Szallitando> szLista;
        public RendelesFrm()
        {
            InitializeComponent();
            szLista = ABKezelo.SzallitandoLekerdez();

            if (dgwRendelesek.Columns.Count == 0)
            {
                dgwRendelesek.Columns.Add("tid", "Termék azonosítója");
                dgwRendelesek.Columns.Add("cikk", "Cikkszám");
                dgwRendelesek.Columns.Add("kat", "Kategória");
                dgwRendelesek.Columns.Add("tnev", "Termék neve");
                dgwRendelesek.Columns.Add("ardarab", "Ár/darab");
                dgwRendelesek.Columns.Add("darab", "Összes darabszám");
                dgwRendelesek.Columns.Add("rendaz", "Rendelési azonosító");
                dgwRendelesek.Columns.Add("renddb", "Rendelt darabszám");
                dgwRendelesek.Columns.Add("vid", "Vevőazonosító");
                dgwRendelesek.Columns.Add("ado", "Adószám(ha van)");
                dgwRendelesek.Columns.Add("vevonev", "Vevő neve");
                dgwRendelesek.Columns.Add("irsz", "Irányítószám");
                dgwRendelesek.Columns.Add("helyseg", "Település");
                dgwRendelesek.Columns.Add("utca", "Utca");
                dgwRendelesek.Columns.Add("hsz", "Házszám");
                dgwRendelesek.Columns.Add("tel", "Telefon");
                dgwRendelesek.Columns.Add("email", "E-mail");
            }
            DgwFrissit();
            
        }

        void DgwFrissit()
        {
            rLista = ABKezelo.RendelesBetolt();
            dgwRendelesek.Rows.Clear();
            foreach (Rendeles item in rLista)
            {
                Vevo v = ABKezelo.RendelesVevoLekerdez(item.Vevoid);
                Aru a = ABKezelo.RendelesTermekLekerdez(item.Termekid);
                dgwRendelesek.Rows.Add(a.Id, a.Cikkszam, a.TermekKategoria, a.Nev, a.Darabar, a.Darab, item.Id, item.Darab, v.Id, v.Adoszam, v.Nev, v.Irsz, v.Helyseg, v.Utca, v.Hsz, v.Telefon, v.Email);
            }
        }
        private void SzallitasFrm_Load(object sender, EventArgs e)
        {
            
        }

     
        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgwFrissit();
        }

        private void szállításraKijelöltTételekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtDBuzenet.Text = "";
                if (szLista.Count == 0)
                {
                    MessageBox.Show("Nincs kijelölt tétel", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SzallitasFrm diag = new SzallitasFrm();
                   

                    diag.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                
            }
            
        }

        private void dgwRendelesek_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow adat = dgwRendelesek.SelectedRows[0];
                int rendid = Convert.ToInt32(adat.Cells[6].FormattedValue);
                int vevid = Convert.ToInt32(adat.Cells[8].FormattedValue);
                int termid = Convert.ToInt32(adat.Cells[0].FormattedValue);
                kijeloltAru = ABKezelo.RendelesTermekLekerdez(termid);
                kijeloltVevo = ABKezelo.RendelesVevoLekerdez(vevid);
                kijeloltRendeles = rLista.Where(x => x.Id == rendid).FirstOrDefault();
                kijelolsor = dgwRendelesek.Rows.IndexOf(adat);
                if (RendelesTartalmaz(rendid))
                {
                    btnSzallitas.Text = "Kijelölés visszavonása";
                }
                else
                {
                    btnSzallitas.Text = "Szállításra kijelöl";
                }
            }
            catch (Exception)
            {

               
            }
            
        }

        private void dgwRendelesek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool RendelesTartalmaz(int id, ref int index)
        {
            bool tartalmaz = false;
            for (int i = 0; i < szLista.Count; i++)
            {
                if (szLista[i].Rid==id)
                {
                    tartalmaz=true;
                    index = i;
                }
            }
            return tartalmaz;
        }
        bool RendelesTartalmaz(int id)
        {
            bool tartalmaz = false;
            for (int i = 0; i < szLista.Count; i++)
            {
                if (szLista[i].Rid == id)
                {
                    tartalmaz = true;
                    
                }
            }
            return tartalmaz;
        }

        private void btnSzallitas_Click(object sender, EventArgs e)
        {
            try
            {
                int index=0;
                Szallitando sz = new Szallitando(0, kijeloltVevo.Id,kijeloltRendeles.Id, kijeloltAru.Id);
               
                
                if (RendelesTartalmaz(sz.Rid,ref index))
                {
                    dgwRendelesek.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                               
                    try
                    {
                        foreach (Szallitando item in szLista)
                        {
                            if (item.Rid == kijeloltRendeles.Id)
                            {
                                sz.Id = item.Id;
                            }
                        }
                        btnSzallitas.Text = "Szállításra kijelöl";
                        szLista.RemoveAt(index);
                        ABKezelo.SzallitandoTorol(sz);
                    }
                    catch (Exception ex)
                    {

                        txtDBuzenet.Text += "Rendelési azonosító már létezik: " + sz.Rid + "\n";
                    }

                }
                else
                {
                    dgwRendelesek.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    
                    btnSzallitas.Text = "Kijelölés visszavonása";
                    
                        try
                        {
                        szLista.Add(sz);
                        ABKezelo.SzallitandoHozzaad(sz);
                        }
                        catch (Exception ex)
                        {

                            txtDBuzenet.Text += "Rendelési azonosító már létezik: " + sz.Rid + "\n";
                        }

                    

                }

            }
            catch (Exception)
            {

                
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (dgwRendelesek.Rows.Count!=0)
            {
                rLista.RemoveAt(dgwRendelesek.SelectedRows[0].Index);
                ABKezelo.RendelesTorol(kijeloltRendeles.Id);
                kijeloltAru = null;
                kijeloltRendeles = null;
                kijeloltVevo = null;
                DgwFrissit();
            }
        }

        private void btnSzamlakeszit_Click(object sender, EventArgs e)
        {
            if (kijeloltRendeles!=null)
            {
                
                    Fajlkezelo.PDFMentes(kijeloltVevo, kijeloltAru, kijeloltRendeles);
                
            }
            
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
