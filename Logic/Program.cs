using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                var curTheme = new Theme
                {
                    ThemeName = "Christmas",
                    
                };
                context.Themes.AddOrUpdate(a => a.ThemeName, curTheme);
                context.Images.Add(new Image
                {
                    Picture = img,
                    ThemeID = curTheme.ID
                });
                context.SaveChanges();
                
            }
        }
    }
}

