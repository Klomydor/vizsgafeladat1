using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktár
{
    public enum TKategoria
    {
        Kormány=1,
        Fék,
        Váltó,
        Kerék,
        Nyereg,
    Hajtás,
    MTB,
    Trekking,
    Országúti,
    BMX,
    Elektromos
    }
    internal class Aru
    {
        int id;
        string cikkszam;
        TKategoria termekKategoria;
        string nev;
        int darabar;
        int darab;
        string kephely;

        public Aru(int id, string cikkszam, TKategoria termekKategoria, string nev, int darabar, int darab, string kephely)
        {
            Id = id;
            Cikkszam = cikkszam;
            TermekKategoria = termekKategoria;
            Nev = nev;
            Darabar = darabar;
            Darab = darab;
            Kephely = kephely;
        }

        public int Id { get => id; set => id = value; }
        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        public TKategoria TermekKategoria { get => termekKategoria; set => termekKategoria = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Darabar { get => darabar; set => darabar = value; }
        public int Darab { get => darab; set => darab = value; }
        public string Kephely { get => kephely; set => kephely = value; }
    }
}
