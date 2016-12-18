using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PictureForProject
    {
        public int ID { get; set; }
        public byte[] PictureCard { get; set; }

        public Theme Theme { get; set; }
        public int ThemeID { get; set; }
    }
}
