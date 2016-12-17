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
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
