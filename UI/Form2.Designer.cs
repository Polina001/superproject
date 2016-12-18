namespace UI
{
    partial class Form2
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Create = new MetroFramework.Controls.MetroButton();
            this.metroButton_1 = new MetroFramework.Controls.MetroButton();
            this.SendToEmail = new MetroFramework.Controls.MetroButton();
            this.Clean = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(502, 117);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(177, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 397);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(501, 326);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(177, 29);
            this.Create.Style = MetroFramework.MetroColorStyle.Lime;
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // metroButton_1
            // 
            this.metroButton_1.Location = new System.Drawing.Point(597, 469);
            this.metroButton_1.Name = "metroButton_1";
            this.metroButton_1.Size = new System.Drawing.Size(82, 29);
            this.metroButton_1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton_1.TabIndex = 3;
            this.metroButton_1.Text = "Exit";
            this.metroButton_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton_1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SendToEmail
            // 
            this.SendToEmail.Location = new System.Drawing.Point(502, 469);
            this.SendToEmail.Name = "SendToEmail";
            this.SendToEmail.Size = new System.Drawing.Size(82, 29);
            this.SendToEmail.Style = MetroFramework.MetroColorStyle.Lime;
            this.SendToEmail.TabIndex = 4;
            this.SendToEmail.Text = "Send to email";
            this.SendToEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SendToEmail.Click += new System.EventHandler(this.SendToEmail_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(501, 394);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(177, 29);
            this.Clean.Style = MetroFramework.MetroColorStyle.Lime;
            this.Clean.TabIndex = 5;
            this.Clean.Text = "Clean";
            this.Clean.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(19, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Here you can see your card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(488, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose the theme of your card\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(508, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click \"Create\" to see what \r\nyou\'ve done :)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(521, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Click \"Clean\" to create\r\nnew card";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.SendToEmail);
            this.Controls.Add(this.metroButton_1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Create your card";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton Create;
        private MetroFramework.Controls.MetroButton metroButton_1;
        private MetroFramework.Controls.MetroButton SendToEmail;
        private MetroFramework.Controls.MetroButton Clean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}