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
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Lime;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void SendToEmail_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            //здесь создается картинка и выводится в pictureBox
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //выпадающий список тем
        }
    }
}
