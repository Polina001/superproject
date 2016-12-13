namespace UI
{
    partial class Form3
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.SendToEmail = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.YellowGreen;
            this.metroLabel1.Location = new System.Drawing.Point(73, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enter your current email";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(43, 141);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(216, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "example@email.com";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(157, 223);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(102, 29);
            this.Exit.Style = MetroFramework.MetroColorStyle.Lime;
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SendToEmail
            // 
            this.SendToEmail.Location = new System.Drawing.Point(43, 223);
            this.SendToEmail.Name = "SendToEmail";
            this.SendToEmail.Size = new System.Drawing.Size(102, 29);
            this.SendToEmail.Style = MetroFramework.MetroColorStyle.Lime;
            this.SendToEmail.TabIndex = 5;
            this.SendToEmail.Text = "Send to email";
            this.SendToEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SendToEmail.Click += new System.EventHandler(this.SendToEmail_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.SendToEmail);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form3";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Email authentication";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton Exit;
        private MetroFramework.Controls.MetroButton SendToEmail;
    }
}