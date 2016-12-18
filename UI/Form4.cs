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
using System.IO;

namespace UI
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Lime;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;

            imageList1 = new ImageList();
            imageList1.ImageSize = new Size(255, 255);

            //imageList1.Images.Add(Image.FromFile(@"C:\Users\ASUSPC\Desktop\Всякая мутатень\нг\нг1.jpg"));

            //var testID = 1;

            //Logic.CreatingListOfImages cloi = new Logic.CreatingListOfImages();
            //var ListOfImages = cloi.ConvertingToListOfImages(testID);

            //foreach (var item in ListOfImages)
            //{

        }


        //    private void Form4_Load(object sender, EventArgs e)
        //{

        //    DirectoryInfo dir = new DirectoryInfo(@"C:\Рабочий стол\Всякая мутатень\нг");

        //    foreach (FileInfo file in dir.GetFiles())
        //    {
        //        try
        //        {
        //            this.imageList1.Images.Add(Image.FromFile(file.FullName));
        //        }
        //        catch
        //        {
        //        }
        //    }

        //    this.listView1.View = View.LargeIcon;

        //    this.imageList1.ImageSize = new Size(100, 80);

        //    this.listView1.LargeImageList = this.imageList1;

        //    for (int j = 0; j < this.imageList1.Images.Count; j++)
        //    {

        //        ListViewItem item = new ListViewItem();

        //        item.ImageIndex = j;

        //        this.listView1.Items.Add(item);

        //    }
        //}

        private void metroButton_1_Click(object sender, EventArgs e)
        {
            //string StringNumber = metroTextBox1.Text;

            //var PictureNumber = int.Parse(StringNumber);

            ActiveForm.Close();
        }
    }
}

