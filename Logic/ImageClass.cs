using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class ImageClass
    {
        public int ID { get; set; }
        public byte[] Picture { get; set; }

        public int ThemeID { get; set; }
        public Theme Theme { get; set; }

    }
}
