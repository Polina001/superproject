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
            System.Drawing.Image FinalPostCard = new Bitmap(1550, 795);

            Graphics GraphicFinalPostCard = Graphics.FromImage(FinalPostCard);

            Rectangle rectangle = new Rectangle(0, 0, 550, 795);


            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            Region fillrectangle = new Region(rectangle);

            // GraphicFinalPostCard.FillRegion(blueBrush, fillrectangle);

            GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile(@"../../img1.jpg"), new Rectangle(0, 0, FinalPostCard.Width/2, FinalPostCard.Height));

            GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile(@"../../img3.jpg"), new Rectangle(FinalPostCard.Width/2, 0, FinalPostCard.Width/2, FinalPostCard.Height));

            FinalPostCard.Save(@"../../final3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine("done");

            Console.ReadKey();




        }

    }
}
