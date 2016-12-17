namespace UI
{
    partial class Form5
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
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(824, 483);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(102, 29);
            this.Exit.Style = MetroFramework.MetroColorStyle.Lime;
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 535);
            this.Controls.Add(this.Exit);
            this.Name = "Form5";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Choose your text";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Exit;
    }
}