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
using System.Drawing.Text;

namespace UI
{
    public partial class ChrisPost : MetroForm
    {
        public ChrisPost()
        {
            InitializeComponent();

            fontsProjects();
            fonts();



            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Lime;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        PrivateFontCollection font;
        private void fontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("fonts/Picaso.otf");
        }

        private void fonts()
        {
            //Задаем шрифт текста, отображаемого элементом управления.
            metroLabel1.Font = new Font(font.Families[0], 31);//Picaso.otf
        }
    }
}
