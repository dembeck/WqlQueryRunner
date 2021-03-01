namespace WqlQueryRunner
{
    partial class ScriptActionEditor
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
            this.groupScriptingHost = new System.Windows.Forms.GroupBox();
            this.checkLimitInstances = new System.Windows.Forms.CheckBox();
            this.numericInstanceLimit = new System.Windows.Forms.NumericUpDown();
            this.radioWScript = new System.Windows.Forms.RadioButton();
            this.radioCScript = new System.Windows.Forms.RadioButton();
            this.lblScriptHost = new System.Windows.Forms.Label();
            this.groupScript = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseForScript = new System.Windows.Forms.Button();
            this.txtScriptText = new System.Windows.Forms.TextBox();
            this.txtScriptPath = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openScriptFile = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActionName = new System.Windows.Forms.TextBox();
            this.groupScriptingHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInstanceLimit)).BeginInit();
            this.groupScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupScriptingHost
            // 
            this.groupScriptingHost.Controls.Add(this.checkLimitInstances);
            this.groupScriptingHost.Controls.Add(this.numericInstanceLimit);
            this.groupScriptingHost.Controls.Add(this.radioWScript);
            this.groupScriptingHost.Controls.Add(this.radioCScript);
            this.groupScriptingHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupScriptingHost.ForeColor = System.Drawing.Color.Black;
            this.groupScriptingHost.Location = new System.Drawing.Point(12, 65);
            this.groupScriptingHost.Name = "groupScriptingHost";
            this.groupScriptingHost.Size = new System.Drawing.Size(391, 125);
            this.groupScriptingHost.TabIndex = 0;
            this.groupScriptingHost.TabStop = false;
            this.groupScriptingHost.Text = "Run Script Options";
            // 
            // checkLimitInstances
            // 
            this.checkLimitInstances.AutoSize = true;
            this.checkLimitInstances.Checked = true;
            this.checkLimitInstances.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLimitInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLimitInstances.Location = new System.Drawing.Point(36, 85);
            this.checkLimitInstances.Name = "checkLimitInstances";
            this.checkLimitInstances.Size = new System.Drawing.Size(175, 34);
            this.checkLimitInstances.TabIndex = 4;
            this.checkLimitInstances.Text = "Limit the number of scripts\r\nthat can run simultaneously";
            this.checkLimitInstances.UseVisualStyleBackColor = true;
            this.checkLimitInstances.CheckedChanged += new System.EventHandler(this.checkLimitInstances_CheckedChanged);
            // 
            // numericInstanceLimit
            // 
            this.numericInstanceLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericInstanceLimit.Location = new System.Drawing.Point(237, 92);
            this.numericInstanceLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericInstanceLimit.Name = "numericInstanceLimit";
            this.numericInstanceLimit.Size = new System.Drawing.Size(102, 21);
            this.numericInstanceLimit.TabIndex = 2;
            this.numericInstanceLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioWScript
            // 
            this.radioWScript.AutoSize = true;
            this.radioWScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWScript.Location = new System.Drawing.Point(36, 45);
            this.radioWScript.Name = "radioWScript";
            this.radioWScript.Size = new System.Drawing.Size(187, 19);
            this.radioWScript.TabIndex = 1;
            this.radioWScript.Text = "Windows based scripting host";
            this.radioWScript.UseVisualStyleBackColor = true;
            // 
            // radioCScript
            // 
            this.radioCScript.AutoSize = true;
            this.radioCScript.Checked = true;
            this.radioCScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCScript.Location = new System.Drawing.Point(36, 20);
            this.radioCScript.Name = "radioCScript";
            this.radioCScript.Size = new System.Drawing.Size(182, 19);
            this.radioCScript.TabIndex = 0;
            this.radioCScript.TabStop = true;
            this.radioCScript.Text = "Console based scripting host";
            this.radioCScript.UseVisualStyleBackColor = true;
            this.radioCScript.CheckedChanged += new System.EventHandler(this.radioCScript_CheckedChanged);
            // 
            // lblScriptHost
            // 
            this.lblScriptHost.AutoSize = true;
            this.lblScriptHost.Location = new System.Drawing.Point(197, 65);
            this.lblScriptHost.Name = "lblScriptHost";
            this.lblScriptHost.Size = new System.Drawing.Size(0, 13);
            this.lblScriptHost.TabIndex = 5;
            this.lblScriptHost.Visible = false;
            // 
            // groupScript
            // 
            this.groupScript.Controls.Add(this.label2);
            this.groupScript.Controls.Add(this.label1);
            this.groupScript.Controls.Add(this.btnBrowseForScript);
            this.groupScript.Controls.Add(this.txtScriptText);
            this.groupScript.Controls.Add(this.txtScriptPath);
            this.groupScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupScript.ForeColor = System.Drawing.Color.Black;
            this.groupScript.Location = new System.Drawing.Point(13, 196);
            this.groupScript.Name = "groupScript";
            this.groupScript.Size = new System.Drawing.Size(390, 216);
            this.groupScript.TabIndex = 1;
            this.groupScript.TabStop = false;
            this.groupScript.Text = "Select ActiveX script file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Script text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Script file path";
            // 
            // btnBrowseForScript
            // 
            this.btnBrowseForScript.Location = new System.Drawing.Point(344, 47);
            this.btnBrowseForScript.Name = "btnBrowseForScript";
            this.btnBrowseForScript.Size = new System.Drawing.Size(27, 23);
            this.btnBrowseForScript.TabIndex = 3;
            this.btnBrowseForScript.Text = "...";
            this.btnBrowseForScript.UseVisualStyleBackColor = true;
            this.btnBrowseForScript.Click += new System.EventHandler(this.btnBrowseForScript_Click);
            // 
            // txtScriptText
            // 
            this.txtScriptText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScriptText.Location = new System.Drawing.Point(36, 105);
            this.txtScriptText.Multiline = true;
            this.txtScriptText.Name = "txtScriptText";
            this.txtScriptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScriptText.Size = new System.Drawing.Size(335, 105);
            this.txtScriptText.TabIndex = 1;
            // 
            // txtScriptPath
            // 
            this.txtScriptPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScriptPath.Location = new System.Drawing.Point(36, 48);
            this.txtScriptPath.Name = "txtScriptPath";
            this.txtScriptPath.Size = new System.Drawing.Size(302, 21);
            this.txtScriptPath.TabIndex = 0;
            this.txtScriptPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScriptPath_KeyPress);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(249, 432);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openScriptFile
            // 
            this.openScriptFile.AddExtension = false;
            this.openScriptFile.Filter = "VBScript files|*.vbs|JScript files|*.js";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Action name";
            // 
            // txtActionName
            // 
            this.txtActionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActionName.Location = new System.Drawing.Point(51, 32);
            this.txtActionName.Name = "txtActionName";
            this.txtActionName.Size = new System.Drawing.Size(352, 21);
            this.txtActionName.TabIndex = 5;
            // 
            // ScriptActionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 467);
            this.Controls.Add(this.lblScriptHost);
            this.Controls.Add(this.txtActionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupScript);
            this.Controls.Add(this.groupScriptingHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ScriptActionEditor";
            this.ShowInTaskbar = false;
            this.Text = "ScriptActionEditor";
            this.groupScriptingHost.ResumeLayout(false);
            this.groupScriptingHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInstanceLimit)).EndInit();
            this.groupScript.ResumeLayout(false);
            this.groupScript.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupScriptingHost;
        private System.Windows.Forms.RadioButton radioWScript;
        private System.Windows.Forms.RadioButton radioCScript;
        private System.Windows.Forms.GroupBox groupScript;
        private System.Windows.Forms.TextBox txtScriptPath;
        private System.Windows.Forms.TextBox txtScriptText;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseForScript;
        private System.Windows.Forms.OpenFileDialog openScriptFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtActionName;
        private System.Windows.Forms.Label lblScriptHost;
        private System.Windows.Forms.NumericUpDown numericInstanceLimit;
        private System.Windows.Forms.CheckBox checkLimitInstances;
    }
}