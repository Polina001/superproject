using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Logic
{
    public class PuttingTogether
    {
        public void PuttingPicturesTogether()
        {
            System.Drawing.Image FinalPostCard = new Bitmap(1748, 2480);

            Graphics GraphicFinalPostCard = Graphics.FromImage(FinalPostCard);

            Rectangle rectangle = new Rectangle(0, 0, 1748, 2480);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            Region fillrectangle = new Region(rectangle);

            GraphicFinalPostCard.FillRegion(blueBrush, fillrectangle);

            GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile("c:\\img2.jpeg"), new Point(0,0));

            GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile("c:\\img2.jpeg"), new Point(874, 0));

            FinalPostCard.Save(@"/Users/mariakurepova/Desktop/final.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine("done");

            Console.ReadKey();




        }

    }
}
