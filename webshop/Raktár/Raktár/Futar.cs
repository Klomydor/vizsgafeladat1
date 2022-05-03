using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktár
{
    public enum FutarNevek
    {
        FOXPOST,
        GLS,
        DPD
    }
    internal class Futar
    {

        int id;
        string futarnev;
   
        string telefon;
        string email;
        FutarNevek fnev;

        public Futar(int id, string futarnev, string telefon, string email, FutarNevek fnev)
        {
            Id = id;
            Futarnev = futarnev;
            
            Telefon = telefon;
            Email = email;
            Fnev = fnev;
        }

        public int Id { get => id; set => id = value; }
        public string Futarnev { get => futarnev; set => futarnev = value; }
     
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public FutarNevek Fnev { get => fnev; set => fnev = value; }

        public override string ToString()
        {
            return Fnev+" / "+Futarnev+" / "+Telefon;
        }
    }

    
}
