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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "нг1"}, 0, System.Drawing.Color.GreenYellow, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "нг2"}, "нг2.jpg", System.Drawing.Color.GreenYellow, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "нг3"}, "нг3.jpg", System.Drawing.Color.GreenYellow, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "нг4"}, "нг4.jpg", System.Drawing.Color.GreenYellow, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "нг5"}, "нг5.jpg", System.Drawing.Color.GreenYellow, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroButton_1 = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Create = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.ForeColor = System.Drawing.Color.GreenYellow;
            this.metroTextBox1.Location = new System.Drawing.Point(830, 96);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(102, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.Text = "number";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Lime;
            this.metroLabel1.ForeColor = System.Drawing.Color.GreenYellow;
            this.metroLabel1.Location = new System.Drawing.Point(810, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Choose number of pic";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "нг1.jpg");
            this.imageList1.Images.SetKeyName(1, "нг2.jpg");
            this.imageList1.Images.SetKeyName(2, "нг3.jpg");
            this.imageList1.Images.SetKeyName(3, "нг4.jpg");
            this.imageList1.Images.SetKeyName(4, "нг5.jpg");
            // 
            // metroButton_1
            // 
            this.metroButton_1.Location = new System.Drawing.Point(868, 458);
            this.metroButton_1.Name = "metroButton_1";
            this.metroButton_1.Size = new System.Drawing.Size(82, 29);
            this.metroButton_1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton_1.TabIndex = 10;
            this.metroButton_1.Text = "Exit";
            this.metroButton_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton_1.Click += new System.EventHandler(this.metroButton_1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.CheckBoxes = true;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(23, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(771, 414);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(839, 159);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(82, 29);
            this.Create.Style = MetroFramework.MetroColorStyle.Lime;
            this.Create.TabIndex = 12;
            this.Create.Text = "Choose";
            this.Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 500);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroButton_1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "Form4";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Choose your pic";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton metroButton_1;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroButton Create;
    }
}