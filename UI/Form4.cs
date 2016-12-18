using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace UI
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Lime;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;



            //var testID = 1;

            //Logic.CreatingListOfImages cloi = new Logic.CreatingListOfImages();
            //var ListOfImages = cloi.ConvertingToListOfImages(testID);

            //foreach (var item in ListOfImages)
            //{
              
            //}
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string StringNumber = metroTextBox1.Text;

            var PictureNumber = int.Parse(StringNumber);

            ActiveForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {










        }
    }
}
