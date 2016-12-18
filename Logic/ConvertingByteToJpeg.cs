using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logic
{
    class ConvertingByteToJpeg
    {
        public System.Drawing.Image ByteArrayToJpeg(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Position = 0; // this is important
            Image returnImage = Image.FromStream(ms, true);
            return returnImage;
        }
    }
}
