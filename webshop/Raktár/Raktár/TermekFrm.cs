using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Raktár
{
    public partial class TermekFrm : Form
    {
        OpenFileDialog ofd;
        OpenFileDialog ofdModosit;
        List<Aru> aLista = ABKezelo.TermekBetolt();
        Aru kijeloltAru;
        bool kepvalt = false;
        public TermekFrm()
        {
            InitializeComponent();
            cmbKategoria.DataSource = Enum.GetValues(typeof(TKategoria));
            cmbKategoriaModosit.DataSource = Enum.GetValues(typeof(TKategoria));
            if (dgwAdat.Columns.Count == 0)
            {
                dgwAdat.Columns.Add("id", "id");
                dgwAdat.Columns.Add("cikkszam", "Cikkszám");
                dgwAdat.Columns.Add("kategoria", "Kategória");
                dgwAdat.Columns.Add("nev", "Név");
                dgwAdat.Columns.Add("darabar", "Darabár");
                dgwAdat.Columns.Add("darab", "Darab");
                dgwAdat.Columns.Add("kep", "Képp");
            }
            DgwFrissit();

        }

        void DgwFrissit()
        {
            dgwAdat.Rows.Clear();
            aLista= ABKezelo.TermekBetolt();
            foreach (Aru item in aLista)
            {
                dgwAdat.Rows.Add(item.Id, item.Cikkszam, item.TermekKategoria, item.Nev, item.Darabar, item.Darab, item.Kephely);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Termek_Load(object sender, EventArgs e)
        {

        }

        private void btnKep_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pctKep.BackgroundImage = new Bitmap(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd != null)
            {
                string fajlNev = Beallitas.htmlMappa + "\\img\\" + Interaction.InputBox("Milyen néven mentsük a fájlt?") + ".jpg";

                if (!File.Exists(fajlNev))
                {
                    File.Copy(ofd.FileName, fajlNev);

                    string rovidnev = fajlNev.Split('\\')[fajlNev.Split('\\').Length - 2] + "/" + fajlNev.Split('\\')[fajlNev.Split('\\').Length - 1];
                    Aru a = new Aru(0, txtCikkszam.Text, (TKategoria)Convert.ToInt32(cmbKategoria.SelectedIndex + 1), txtNev.Text, Convert.ToInt32(txtDarabar.Text), (int)numDarab.Value, rovidnev);

                    ABKezelo.TermekHozzaAd(a);
                    DgwFrissit();
                }
                else
                {
                    MessageBox.Show("A megadott kép neve már egyszer szerepel a képek között","Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
                
            }
        }

        private void dgwAdat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwAdat_Click(object sender, EventArgs e)
        {
            if (dgwAdat.SelectedRows.Count == 1)
            {
                DataGridViewRow adat = dgwAdat.SelectedRows[0];
                int id = Convert.ToInt32(adat.Cells[0].FormattedValue);
                kijeloltAru = aLista.Where(x => x.Id == id).FirstOrDefault();
                lblID.Text = "Termék ID: " + kijeloltAru.Id;
                txtCikkModosit.Text = kijeloltAru.Cikkszam;
                cmbKategoriaModosit.SelectedIndex = (int)kijeloltAru.TermekKategoria - 1;
                txtNevModosit.Text = kijeloltAru.Nev;
                txtDarabarModosit.Text = kijeloltAru.Darabar.ToString();
                numDarabModosit.Value = (int)kijeloltAru.Darab;
                if (File.Exists(Beallitas.htmlMappa + kijeloltAru.Kephely))
                {
                    pctKepModosit.BackgroundImage = new Bitmap(Beallitas.htmlMappa + kijeloltAru.Kephely);
                }
                else
                {
                    pctKepModosit.BackgroundImage=null;
                }
               

            }
        }

        private void btnKepModosit_Click(object sender, EventArgs e)
        {

            ofdModosit = new OpenFileDialog();
            if (ofdModosit.ShowDialog() == DialogResult.OK)
            {
                pctKepModosit.BackgroundImage = new Bitmap(ofdModosit.FileName);
                kepvalt = true;
            }

        }

        private void btnTermekModosit_Click(object sender, EventArgs e)
        {
            int dbar;
            if (MessageBox.Show("Valóban módosítod a kijelölt elemet?","Módosítás",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (dgwAdat.SelectedRows.Count == 1 && txtCikkModosit.Text != "" && txtNevModosit.Text != "" && txtDarabarModosit.Text != "" && int.TryParse(txtDarabarModosit.Text, out dbar) == true && kijeloltAru != null)
                {
                    if (ofdModosit != null)
                    {
                     
                        string fajlNev = Beallitas.htmlMappa + "\\img\\" + Interaction.InputBox("Milyen néven mentsük a fájlt?") + ".jpg";
                        while (File.Exists(fajlNev))
                        {
                            MessageBox.Show("Ilyen név már létezik. Újat kel megadni: ");
                            fajlNev = Beallitas.htmlMappa+"\\img\\" + Interaction.InputBox("Milyen néven mentsük a fájlt?") + ".jpg";
                        }

                        File.Copy(ofdModosit.FileName, fajlNev);

                        string rovidnev = fajlNev.Split('\\')[fajlNev.Split('\\').Length - 2] + "/" + fajlNev.Split('\\')[fajlNev.Split('\\').Length - 1];
                        Aru a = new Aru(kijeloltAru.Id, txtCikkModosit.Text, (TKategoria)Convert.ToInt32(cmbKategoria.SelectedIndex + 1), txtNevModosit.Text, Convert.ToInt32(txtDarabarModosit.Text), (int)numDarabModosit.Value, rovidnev);
                        ABKezelo.TermekModosit(a,kepvalt);
                        DgwFrissit();
                        kepvalt = false;
                        ofdModosit = null;

                    }
                    else
                    {
                        Aru a = new Aru(kijeloltAru.Id, txtCikkModosit.Text, (TKategoria)Convert.ToInt32(cmbKategoria.SelectedIndex + 1), txtNevModosit.Text, Convert.ToInt32(txtDarabarModosit.Text), (int)numDarabModosit.Value, "");
                        ABKezelo.TermekModosit(a, kepvalt);
                        DgwFrissit();
                    }
                }
            }
            
           
        }

        private void btnKepTorol_Click(object sender, EventArgs e)
        {
            if (kijeloltAru != null)
            {
                ABKezelo.KepTorol(kijeloltAru.Id);
                DgwFrissit();
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valóban törölni szeretnéd a kijelölt árut?","Áru törlése",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ABKezelo.TermekTorol(kijeloltAru.Id);
                pctKepModosit.BackgroundImage = null;
                ofdModosit = null;
               
                DgwFrissit();
                File.Delete(Beallitas.htmlMappa + kijeloltAru.Kephely);
            }
        }
    }
}
