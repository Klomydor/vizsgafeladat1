using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktár
{
    internal class Vevo
    {
        int id;    
        string nev;
        int irsz;
        string helyseg;
        string utca;
        int hsz;
        string telefon;
        string email;
        string adoszam;

        public Vevo(int id, string nev, int irsz, string helyseg, string utca, int hsz, string telefon, string email)
        {
            Id = id;
            Nev = nev;
            Irsz = irsz;
            Helyseg = helyseg;
            Utca = utca;
            Hsz = hsz;
            Telefon = telefon;
            Email = email;
        }

        public Vevo(int id, string nev, int irsz, string helyseg, string utca, int hsz, string telefon, string email, string adoszam)
        {
            Id = id;
            Nev = nev;
            Irsz = irsz;
            Helyseg = helyseg;
            Utca = utca;
            Hsz = hsz;
            Telefon = telefon;
            Email = email;
            Adoszam = adoszam;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Irsz { get => irsz; set => irsz = value; }
        public string Helyseg { get => helyseg; set => helyseg = value; }
        public string Utca { get => utca; set => utca = value; }
        public int Hsz { get => hsz; set => hsz = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Adoszam { get => adoszam; set => adoszam = value; }

        public override string ToString()
        {
            return Nev + " - " + Irsz + " " + Helyseg + " " + Utca + " " + Hsz;
        }
    }
}
