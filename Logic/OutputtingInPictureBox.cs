using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Logic
{
    public class OutputtingInPictureBox
    {
        public void OutputtingPicture(PictureBox pb, System.Drawing.Image image)
        {
            pb.Location = new Point(0, 0);
            pb.Image = image;

        }
    }
}
