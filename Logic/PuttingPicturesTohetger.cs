using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PuttingPicturesTohetger
    {
        public System.Drawing.Image PuttingTogether(System.Drawing.Image image1, System.Drawing.Image image2)
        {
            System.Drawing.Image FinalPostCard = new Bitmap(1550, 795);

            Graphics GraphicFinalPostCard = Graphics.FromImage(FinalPostCard);

            GraphicFinalPostCard.DrawImage(image1, new Rectangle(0, 0, FinalPostCard.Width / 2, FinalPostCard.Height));

            GraphicFinalPostCard.DrawImage(image2, new Rectangle(FinalPostCard.Width / 2, 0, FinalPostCard.Width / 2, FinalPostCard.Height));

            //GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile(@"../../img1.jpg"), new Rectangle(0, 0, FinalPostCard.Width / 2, FinalPostCard.Height));

            //GraphicFinalPostCard.DrawImage(System.Drawing.Image.FromFile(@"../../img3.jpg"), new Rectangle(FinalPostCard.Width / 2, 0, FinalPostCard.Width / 2, FinalPostCard.Height));

            FinalPostCard.Save(@"../../testwithoutUI.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //Console.WriteLine("done");

            //Console.ReadKey();

            return (FinalPostCard);
        }
    }
}
