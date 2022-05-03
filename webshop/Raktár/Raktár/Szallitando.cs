using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktár
{
    internal class Szallitando
    {
        int id;
        int vid;
        int rid;
        int tid;

        public Szallitando(int id, int vid, int rid, int tid)
        {
            Id = id;
            Vid = vid;
            Rid = rid;
            Tid = tid;
        }

        public int Id { get => id; set => id = value; }
        public int Vid { get => vid; set => vid = value; }
        public int Rid { get => rid; set => rid = value; }
        public int Tid { get => tid; set => tid = value; }
    }
}
