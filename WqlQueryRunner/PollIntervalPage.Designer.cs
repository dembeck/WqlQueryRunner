namespace WqlQueryRunner
{
    partial class PollIntervalPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PollIntervalPage));
            this.label1 = new System.Windows.Forms.Label();
            this.upDownPollingInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPollingInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Size = new System.Drawing.Size(432, 28);
            this.Banner.Subtitle = "";
            this.Banner.Title = "Select Polling Interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // upDownPollingInterval
            // 
            this.upDownPollingInterval.DecimalPlaces = 1;
            this.upDownPollingInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownPollingInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDownPollingInterval.Location = new System.Drawing.Point(228, 164);
            this.upDownPollingInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.upDownPollingInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDownPollingInterval.Name = "upDownPollingInterval";
            this.upDownPollingInterval.Size = new System.Drawing.Size(56, 21);
            this.upDownPollingInterval.TabIndex = 2;
            this.upDownPollingInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownPollingInterval.ValueChanged += new System.EventHandler(this.upDownPollingInterval_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Polling interval:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "seconds";
            // 
            // PollIntervalPage
            // 
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upDownPollingInterval);
            this.Name = "PollIntervalPage";
            this.Size = new System.Drawing.Size(432, 217);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.PollIntervalPage_SetActive);
            this.Controls.SetChildIndex(this.upDownPollingInterval, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Banner, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.upDownPollingInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDownPollingInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
