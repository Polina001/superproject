using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class PuttingPicturesTohetger
    {
        public System.Drawing.Image PuttingTogether()
        {
            System.Drawing.Image FinalPostCard = new Bitmap(1550, 795);

            Graphics GraphicFinalPostCard = Graphics.FromImage(FinalPostCard);

            GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile(@"../../img1.jpg"), new Rectangle(0, 0, FinalPostCard.Width / 2, FinalPostCard.Height));

            GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile(@"../../img3.jpg"), new Rectangle(FinalPostCard.Width / 2, 0, FinalPostCard.Width / 2, FinalPostCard.Height));

            FinalPostCard.Save(@"../../finalfornatasha.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //Console.WriteLine("done");

            //Console.ReadKey();

            return (FinalPostCard);
        }
    }
}
