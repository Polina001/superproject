namespace UI
{
    partial class ChrisPost
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SorryNotNow = new MetroFramework.Controls.MetroButton();
            this.Go = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel1.Location = new System.Drawing.Point(42, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(495, 124);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Hello! \r\nWe are welcome to present you a new way to create Christmas cards! \r\nDo " +
    "you want to know more& Click \"Go!\" and you create your own exciting card!";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // SorryNotNow
            // 
            this.SorryNotNow.Location = new System.Drawing.Point(312, 262);
            this.SorryNotNow.Name = "SorryNotNow";
            this.SorryNotNow.Size = new System.Drawing.Size(225, 35);
            this.SorryNotNow.Style = MetroFramework.MetroColorStyle.Lime;
            this.SorryNotNow.TabIndex = 4;
            this.SorryNotNow.Text = "Sorry, not now :(";
            this.SorryNotNow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SorryNotNow.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Go
            // 
            this.Go.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Go.Location = new System.Drawing.Point(42, 262);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(225, 35);
            this.Go.Style = MetroFramework.MetroColorStyle.Lime;
            this.Go.TabIndex = 3;
            this.Go.Text = "Go!";
            this.Go.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Go.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ChrisPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(585, 367);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SorryNotNow);
            this.Controls.Add(this.Go);
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Name = "ChrisPost";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Welcome to ChristPost!";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton SorryNotNow;
        private MetroFramework.Controls.MetroButton Go;
    }
}

