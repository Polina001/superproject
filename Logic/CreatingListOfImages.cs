using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CreatingListOfImages
    {
        public List<System.Drawing.Image> ConvertingToListOfImages(int ID)
        {
            using (var context = new Context())
            {
                var ListOfByteImages = from i in context.Pictures
                                       where i.ThemeID == ID
                                       select i.PictureCard;


                List<Image> ListOfImages = new List<Image>();

                ConvertingByteToJpeg cbj = new ConvertingByteToJpeg();

                foreach (var item in ListOfByteImages)
                {
                    var FinalImageForPostCard = cbj.ByteArrayToJpeg(item);
                    ListOfImages.Add(FinalImageForPostCard);
                }
                return ListOfImages;
            }
        }
    }
}
