﻿using System;
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
    public partial class ChrisPost : MetroForm
    {
        public ChrisPost()
        {
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
    }
}
