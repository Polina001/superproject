using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                // Load file meta data with FileInfo
                FileInfo fileInfo = new FileInfo(@"../../../1.jpg");

                // The byte[] to save the data in
                byte[] img = new byte[fileInfo.Length];

                // Load a filestream and put its content into the byte[]
                using (FileStream fs = fileInfo.OpenRead())
                {
                    fs.Read(img, 0, img.Length);
                }
                context.Images.Add(new Image
                {
                    Picture = img
                });
                context.Themes.Add(new Theme
                {
                    ThemeName = "111"
                });
                context.SaveChanges();
            }
        }
    }
}

