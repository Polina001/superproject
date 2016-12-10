using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Inscription
    {
        public int ID { get; set; }
        public byte[] InscriptionText { get; set; }

        public Theme Theme { get; set; }
    }
}
