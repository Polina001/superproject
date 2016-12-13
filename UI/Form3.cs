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
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Lime;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void SendToEmail_Click(object sender, EventArgs e)
        {
            //код для мэйла здесь
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            //здесь осуществляется ввод мэйла
        }
    }
}
