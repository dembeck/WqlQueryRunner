namespace WqlQueryRunner
{
    partial class SavedItems
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
            this.lstSavedItems = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnQuery = new System.Windows.Forms.ColumnHeader();
            this.columnState = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openQueriesDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstSavedItems
            // 
            this.lstSavedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSavedItems.CheckBoxes = true;
            this.lstSavedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnQuery,
            this.columnState});
            this.lstSavedItems.FullRowSelect = true;
            this.lstSavedItems.GridLines = true;
            this.lstSavedItems.LabelEdit = true;
            this.lstSavedItems.Location = new System.Drawing.Point(12, 12);
            this.lstSavedItems.Name = "lstSavedItems";
            this.lstSavedItems.Size = new System.Drawing.Size(584, 275);
            this.lstSavedItems.TabIndex = 0;
            this.lstSavedItems.UseCompatibleStateImageBehavior = false;
            this.lstSavedItems.View = System.Windows.Forms.View.Details;
            this.lstSavedItems.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstSavedItems_AfterLabelEdit);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 109;
            // 
            // columnQuery
            // 
            this.columnQuery.Text = "Query";
            this.columnQuery.Width = 364;
            // 
            // columnState
            // 
            this.columnState.Text = "State";
            this.columnState.Width = 90;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(521, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(440, 293);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 293);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(304, 293);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open file ...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openQueriesDialog
            // 
            this.openQueriesDialog.DefaultExt = "txt";
            this.openQueriesDialog.Filter = "txt files|*.txt";
            // 
            // SavedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 325);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstSavedItems);
            this.MinimizeBox = false;
            this.Name = "SavedItems";
            this.Text = "SavedItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnQuery;
        private System.Windows.Forms.ColumnHeader columnState;
        public System.Windows.Forms.ListView lstSavedItems;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openQueriesDialog;
    }
}