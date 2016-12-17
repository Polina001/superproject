namespace UI
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(830, 528);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(102, 29);
            this.Exit.Style = MetroFramework.MetroColorStyle.Lime;
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(955, 580);
            this.Controls.Add(this.Exit);
            this.Name = "Form4";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Choose your pic";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton Exit;
    }
}