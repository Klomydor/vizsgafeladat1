using System;


namespace Raktár
{
    internal class Rendeles
    {
        int id;
        int darab;
        int ar;
        int termekid;
        int vevoid;
        FutarNevek fnev;

        public Rendeles(int id, int darab, int ar, int termekid, int vevoid, FutarNevek fnev)
        {
            Id = id;
            Darab = darab;
            Ar = ar;
            Termekid = termekid;
            Vevoid = vevoid;
            Fnev = fnev;
        }

        public int Osszertek()
        {
            return darab * ar;
        }

        public int Netto()
        {
            return Convert.ToInt32(Osszertek() - (Osszertek() * 0.27));
        }
        public int Id { get => id; set => id = value; }
        public int Darab { get => darab; set => darab = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Termekid { get => termekid; set => termekid = value; }
        public int Vevoid { get => vevoid; set => vevoid = value; }
        public FutarNevek Fnev { get => fnev; set => fnev = value; }
    }
}
