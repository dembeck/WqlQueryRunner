namespace WqlQueryRunner
{
    partial class EventTypePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupEventClasses = new System.Windows.Forms.GroupBox();
            this.radioModification = new System.Windows.Forms.RadioButton();
            this.radioOperation = new System.Windows.Forms.RadioButton();
            this.radioDeletion = new System.Windows.Forms.RadioButton();
            this.radioCreation = new System.Windows.Forms.RadioButton();
            this.groupEventClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Size = new System.Drawing.Size(432, 28);
            this.Banner.Subtitle = "";
            this.Banner.Title = "Select Event Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "\r\nYou first need to select the event type. \r\n\r\nYou can subscribe to creation, del" +
                "etion or modification events. You can also subscribe \r\nto all three types of eve" +
                "nts simultaneously.\r\n";
            // 
            // groupEventClasses
            // 
            this.groupEventClasses.Controls.Add(this.radioModification);
            this.groupEventClasses.Controls.Add(this.radioOperation);
            this.groupEventClasses.Controls.Add(this.radioDeletion);
            this.groupEventClasses.Controls.Add(this.radioCreation);
            this.groupEventClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEventClasses.Location = new System.Drawing.Point(152, 112);
            this.groupEventClasses.Name = "groupEventClasses";
            this.groupEventClasses.Size = new System.Drawing.Size(200, 112);
            this.groupEventClasses.TabIndex = 2;
            this.groupEventClasses.TabStop = false;
            // 
            // radioModification
            // 
            this.radioModification.AutoSize = true;
            this.radioModification.Location = new System.Drawing.Point(16, 56);
            this.radioModification.Name = "radioModification";
            this.radioModification.Size = new System.Drawing.Size(175, 19);
            this.radioModification.TabIndex = 2;
            this.radioModification.TabStop = true;
            this.radioModification.Text = "Monitor modification events";
            this.radioModification.UseVisualStyleBackColor = true;
            this.radioModification.CheckedChanged += new System.EventHandler(this.radioModification_CheckedChanged);
            // 
            // radioOperation
            // 
            this.radioOperation.AutoSize = true;
            this.radioOperation.Location = new System.Drawing.Point(16, 80);
            this.radioOperation.Name = "radioOperation";
            this.radioOperation.Size = new System.Drawing.Size(121, 19);
            this.radioOperation.TabIndex = 3;
            this.radioOperation.TabStop = true;
            this.radioOperation.Text = "Monitor all events";
            this.radioOperation.UseVisualStyleBackColor = true;
            this.radioOperation.CheckedChanged += new System.EventHandler(this.radioOperation_CheckedChanged);
            // 
            // radioDeletion
            // 
            this.radioDeletion.AutoSize = true;
            this.radioDeletion.Location = new System.Drawing.Point(16, 32);
            this.radioDeletion.Name = "radioDeletion";
            this.radioDeletion.Size = new System.Drawing.Size(152, 19);
            this.radioDeletion.TabIndex = 1;
            this.radioDeletion.TabStop = true;
            this.radioDeletion.Text = "Monitor deletion events";
            this.radioDeletion.UseVisualStyleBackColor = true;
            this.radioDeletion.CheckedChanged += new System.EventHandler(this.radioDeletion_CheckedChanged);
            // 
            // radioCreation
            // 
            this.radioCreation.AutoSize = true;
            this.radioCreation.Checked = true;
            this.radioCreation.Location = new System.Drawing.Point(16, 8);
            this.radioCreation.Name = "radioCreation";
            this.radioCreation.Size = new System.Drawing.Size(152, 19);
            this.radioCreation.TabIndex = 0;
            this.radioCreation.TabStop = true;
            this.radioCreation.Text = "Monitor creation events";
            this.radioCreation.UseVisualStyleBackColor = true;
            this.radioCreation.CheckedChanged += new System.EventHandler(this.radioCreation_CheckedChanged);
            // 
            // EventTypePage
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupEventClasses);
            this.Name = "EventTypePage";
            this.Size = new System.Drawing.Size(432, 283);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.EventTypePage_SetActive);
            this.Controls.SetChildIndex(this.groupEventClasses, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Banner, 0);
            this.groupEventClasses.ResumeLayout(false);
            this.groupEventClasses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioModification;
        private System.Windows.Forms.RadioButton radioOperation;
        private System.Windows.Forms.RadioButton radioDeletion;
        private System.Windows.Forms.RadioButton radioCreation;
        internal System.Windows.Forms.GroupBox groupEventClasses;
    }
}
