using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Raktár
{
    public partial class ElinditottFrm : Form
    {
        List<Vevo> vevoList;
        List<Aru> aruList;
        List<Rendeles> rendelesList;
        List<Szallitando> szallitandoList;
        List<Elinditott> elinditottList;
        Rendeles kijeloltRendeles;
        int rendelesId = 0;


        public ElinditottFrm()
        {
            InitializeComponent();
            vevoList = new List<Vevo>();
            aruList = new List<Aru>();  
            rendelesList = new List<Rendeles>();    
            szallitandoList = new List<Szallitando>();
            
            ListaFeltolt();
        }

        void ListaFeltolt()
        {
            try
            {
                lbElinditott.Items.Clear(); 
                elinditottList = ABKezelo.ElinditottBetolt();
                foreach (Elinditott item in elinditottList)
                {
                    Szallitando sz = ABKezelo.SzallitandoLekerdez().Where(x => x.Id == item.SzallitasId).First();
                    szallitandoList.Add(sz);
                }
                foreach (Szallitando item in szallitandoList)
                {
                    Rendeles r = ABKezelo.RendelesBetolt().Where(x => x.Id == item.Rid).First();
                    rendelesList.Add(r);
                }
                foreach (Rendeles item in rendelesList)
                {
                    Aru a = ABKezelo.RendelesTermekLekerdez(item.Termekid);
                    aruList.Add(a);
                    Vevo v = ABKezelo.RendelesVevoLekerdez(item.Vevoid);
                    vevoList.Add(v);
                    if (a!=null&&v!=null)
                    {
                        lbElinditott.Items.Add(item.Id+";"+v+";" + a.Nev + ";" + item.Darab + " darab " + item.Osszertek() + " Ft");
                    }
                    
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Jelenleg nincs futárnak átadott csomag");
            }
            
        }

        private void ElinditottFrm_Load(object sender, EventArgs e)
        {

        }

        private void lbElinditott_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbElinditott.SelectedIndex!=-1)
            {
                rendelesId = Convert.ToInt32(lbElinditott.SelectedItem.ToString().Split(';')[0]);
                kijeloltRendeles = rendelesList.Where(x => x.Id == rendelesId).First();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kijeloltSzallitasId = szallitandoList.Where(x => x.Rid == rendelesId).First().Id;
                Aru jelenlegiAru=aruList.Where(x=>x.Id==(szallitandoList.Where(y=>y.Id==kijeloltSzallitasId).First().Tid)).First();
                jelenlegiAru.Darab -= kijeloltRendeles.Darab;
                ABKezelo.TermekModosit(jelenlegiAru, false);
                ABKezelo.ElinditottTorol(kijeloltSzallitasId);
                ABKezelo.RendelesTorol(rendelesId);
                ABKezelo.SzallitandoTorol(rendelesId);
                ListaFeltolt();
            }
            catch (Exception)
            {

                
            }
           
        }

        private void btnSzallitasNemOk_Click(object sender, EventArgs e)
        {
            int kijeloltSzallitasId = szallitandoList.Where(x => x.Rid == rendelesId).First().Id;
            ABKezelo.ElinditottTorol(kijeloltSzallitasId);
            if (MessageBox.Show("Töröljük a kijelölt tételt a rendelések közül is?","Törlés",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ABKezelo.RendelesTorol(rendelesId);
            }
        }
    }
}
