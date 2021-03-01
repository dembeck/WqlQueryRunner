namespace WqlQueryRunner
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.Size = new System.Drawing.Size(165, 224);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 88);
            this.label1.MinimumSize = new System.Drawing.Size(280, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Create Event Query Wizard!\r\n\r\nThis wizard will guide you through t" +
                "he steps  needed to create \r\na WQL event query.";
            // 
            // WelcomePage
            // 
            this.Controls.Add(this.label1);
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(481, 224);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.WelcomePage_SetActive);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Sidebar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

    }
}
