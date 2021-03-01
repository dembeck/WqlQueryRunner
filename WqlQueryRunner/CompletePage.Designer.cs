namespace WqlQueryRunner
{
    partial class CompletePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletePage));
            this.label1 = new System.Windows.Forms.Label();
            this.groupExitOptions = new System.Windows.Forms.GroupBox();
            this.radioClose = new System.Windows.Forms.RadioButton();
            this.radioEdit = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.txtQueryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupExitOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.Size = new System.Drawing.Size(165, 244);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 21);
            this.label1.MinimumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "You have successfully completed the Create Event Query Wizard!\r\n\r\nYou can choose " +
                "to add the query to the monitored item list, \r\n or to manually edit it.";
            // 
            // groupExitOptions
            // 
            this.groupExitOptions.Controls.Add(this.radioClose);
            this.groupExitOptions.Controls.Add(this.radioEdit);
            this.groupExitOptions.Controls.Add(this.radioAdd);
            this.groupExitOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupExitOptions.Location = new System.Drawing.Point(180, 148);
            this.groupExitOptions.Name = "groupExitOptions";
            this.groupExitOptions.Size = new System.Drawing.Size(308, 84);
            this.groupExitOptions.TabIndex = 2;
            this.groupExitOptions.TabStop = false;
            // 
            // radioClose
            // 
            this.radioClose.AutoSize = true;
            this.radioClose.Location = new System.Drawing.Point(4, 56);
            this.radioClose.Name = "radioClose";
            this.radioClose.Size = new System.Drawing.Size(195, 19);
            this.radioClose.TabIndex = 2;
            this.radioClose.Text = "Close the wizard without saving";
            this.radioClose.UseVisualStyleBackColor = true;
            // 
            // radioEdit
            // 
            this.radioEdit.AutoSize = true;
            this.radioEdit.Location = new System.Drawing.Point(4, 36);
            this.radioEdit.Name = "radioEdit";
            this.radioEdit.Size = new System.Drawing.Size(99, 19);
            this.radioEdit.TabIndex = 1;
            this.radioEdit.Text = "Edit the query";
            this.radioEdit.UseVisualStyleBackColor = true;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Checked = true;
            this.radioAdd.Location = new System.Drawing.Point(4, 16);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(236, 19);
            this.radioAdd.TabIndex = 0;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add the query to the monitored item list";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // txtQueryName
            // 
            this.txtQueryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueryName.Location = new System.Drawing.Point(316, 116);
            this.txtQueryName.Name = "txtQueryName";
            this.txtQueryName.Size = new System.Drawing.Size(172, 21);
            this.txtQueryName.TabIndex = 3;
            this.txtQueryName.Text = "untitled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monitored item name";
            // 
            // CompletePage
            // 
            this.Controls.Add(this.txtQueryName);
            this.Controls.Add(this.groupExitOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompletePage";
            this.Size = new System.Drawing.Size(498, 244);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.CompletePage_SetActive);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupExitOptions, 0);
            this.Controls.SetChildIndex(this.txtQueryName, 0);
            this.Controls.SetChildIndex(this.Sidebar, 0);
            this.groupExitOptions.ResumeLayout(false);
            this.groupExitOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupExitOptions;
        private System.Windows.Forms.RadioButton radioEdit;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioClose;
        private System.Windows.Forms.TextBox txtQueryName;
        private System.Windows.Forms.Label label2;
    }
}
