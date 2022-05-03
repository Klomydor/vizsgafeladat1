using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktár
{
    internal class Elinditott
    {
        int id;
        int szallitasId;
        int futarId;

        public Elinditott(int id, int szallitasId, int futarId)
        {
            Id = id;
            SzallitasId = szallitasId;
            FutarId = futarId;
        }

        public int Id { get => id; set => id = value; }
        public int SzallitasId { get => szallitasId; set => szallitasId = value; }
        public int FutarId { get => futarId; set => futarId = value; }

        public override string ToString()
        {
            return szallitasId + " - " + futarId;
        }
    }
}
