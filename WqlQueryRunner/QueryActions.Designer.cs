namespace WqlQueryRunner
{
    partial class QueryActions
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
            this.lstEventActions = new System.Windows.Forms.ListView();
            this.ActionName = new System.Windows.Forms.ColumnHeader();
            this.ActionState = new System.Windows.Forms.ColumnHeader();
            this.btnScriptAction = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNTEventLogAction = new System.Windows.Forms.Button();
            this.btnCmdLineAction = new System.Windows.Forms.Button();
            this.btnSMTPAction = new System.Windows.Forms.Button();
            this.btnLogFileAction = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEventActions
            // 
            this.lstEventActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEventActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionName,
            this.ActionState});
            this.lstEventActions.FullRowSelect = true;
            this.lstEventActions.GridLines = true;
            this.lstEventActions.Location = new System.Drawing.Point(12, 12);
            this.lstEventActions.MultiSelect = false;
            this.lstEventActions.Name = "lstEventActions";
            this.lstEventActions.Size = new System.Drawing.Size(381, 405);
            this.lstEventActions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstEventActions.TabIndex = 0;
            this.lstEventActions.UseCompatibleStateImageBehavior = false;
            this.lstEventActions.View = System.Windows.Forms.View.Details;
            // 
            // ActionName
            // 
            this.ActionName.Text = "Action name";
            this.ActionName.Width = 177;
            // 
            // ActionState
            // 
            this.ActionState.Text = "Action state";
            this.ActionState.Width = 194;
            // 
            // btnScriptAction
            // 
            this.btnScriptAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScriptAction.Location = new System.Drawing.Point(13, 29);
            this.btnScriptAction.Name = "btnScriptAction";
            this.btnScriptAction.Size = new System.Drawing.Size(111, 23);
            this.btnScriptAction.TabIndex = 1;
            this.btnScriptAction.Text = "Run script";
            this.btnScriptAction.UseVisualStyleBackColor = true;
            this.btnScriptAction.Click += new System.EventHandler(this.btnScriptAction_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(413, 215);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit action";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnNTEventLogAction);
            this.groupBox1.Controls.Add(this.btnCmdLineAction);
            this.groupBox1.Controls.Add(this.btnSMTPAction);
            this.groupBox1.Controls.Add(this.btnLogFileAction);
            this.groupBox1.Controls.Add(this.btnScriptAction);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(399, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new action:";
            // 
            // btnNTEventLogAction
            // 
            this.btnNTEventLogAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNTEventLogAction.Enabled = false;
            this.btnNTEventLogAction.Location = new System.Drawing.Point(13, 141);
            this.btnNTEventLogAction.Name = "btnNTEventLogAction";
            this.btnNTEventLogAction.Size = new System.Drawing.Size(111, 23);
            this.btnNTEventLogAction.TabIndex = 5;
            this.btnNTEventLogAction.Text = "Log to event log";
            this.btnNTEventLogAction.UseVisualStyleBackColor = true;
            // 
            // btnCmdLineAction
            // 
            this.btnCmdLineAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmdLineAction.Enabled = false;
            this.btnCmdLineAction.Location = new System.Drawing.Point(13, 113);
            this.btnCmdLineAction.Name = "btnCmdLineAction";
            this.btnCmdLineAction.Size = new System.Drawing.Size(111, 23);
            this.btnCmdLineAction.TabIndex = 4;
            this.btnCmdLineAction.Text = "Execute program";
            this.btnCmdLineAction.UseVisualStyleBackColor = true;
            // 
            // btnSMTPAction
            // 
            this.btnSMTPAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSMTPAction.Enabled = false;
            this.btnSMTPAction.Location = new System.Drawing.Point(13, 85);
            this.btnSMTPAction.Name = "btnSMTPAction";
            this.btnSMTPAction.Size = new System.Drawing.Size(111, 23);
            this.btnSMTPAction.TabIndex = 3;
            this.btnSMTPAction.Text = "Send e-mail";
            this.btnSMTPAction.UseVisualStyleBackColor = true;
            // 
            // btnLogFileAction
            // 
            this.btnLogFileAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogFileAction.Enabled = false;
            this.btnLogFileAction.Location = new System.Drawing.Point(13, 57);
            this.btnLogFileAction.Name = "btnLogFileAction";
            this.btnLogFileAction.Size = new System.Drawing.Size(111, 23);
            this.btnLogFileAction.TabIndex = 2;
            this.btnLogFileAction.Text = "Log to file";
            this.btnLogFileAction.UseVisualStyleBackColor = true;
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivate.Location = new System.Drawing.Point(412, 297);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(111, 23);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeactivate.Location = new System.Drawing.Point(412, 326);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(111, 23);
            this.btnDeactivate.TabIndex = 5;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(448, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(413, 244);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove action";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // QueryActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 429);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstEventActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QueryActions";
            this.ShowInTaskbar = false;
            this.Text = "Manage Query Actions";
            this.Load += new System.EventHandler(this.QueryActions_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstEventActions;
        private System.Windows.Forms.Button btnScriptAction;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader ActionName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSMTPAction;
        private System.Windows.Forms.Button btnLogFileAction;
        private System.Windows.Forms.Button btnNTEventLogAction;
        private System.Windows.Forms.Button btnCmdLineAction;
        private System.Windows.Forms.ColumnHeader ActionState;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemove;
    }
}