namespace WqlQueryRunner
{
    partial class TargetClassPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetClassPage));
            this.label1 = new System.Windows.Forms.Label();
            this.lstTargetClasses = new System.Windows.Forms.ListView();
            this.classNames = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoreItems = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Size = new System.Drawing.Size(476, 28);
            this.Banner.Subtitle = "";
            this.Banner.Title = "Select Items to Monitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lstTargetClasses
            // 
            this.lstTargetClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.classNames});
            this.lstTargetClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTargetClasses.FullRowSelect = true;
            this.lstTargetClasses.GridLines = true;
            this.lstTargetClasses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstTargetClasses.HideSelection = false;
            this.lstTargetClasses.Location = new System.Drawing.Point(8, 8);
            this.lstTargetClasses.MultiSelect = false;
            this.lstTargetClasses.Name = "lstTargetClasses";
            this.lstTargetClasses.Size = new System.Drawing.Size(256, 92);
            this.lstTargetClasses.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstTargetClasses.TabIndex = 2;
            this.lstTargetClasses.UseCompatibleStateImageBehavior = false;
            this.lstTargetClasses.View = System.Windows.Forms.View.Details;
            this.lstTargetClasses.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstTargetClasses_ItemSelectionChanged);
            // 
            // classNames
            // 
            this.classNames.Width = 234;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstTargetClasses);
            this.panel1.Controls.Add(this.btnMoreItems);
            this.panel1.Location = new System.Drawing.Point(52, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 120);
            this.panel1.TabIndex = 6;
            // 
            // btnMoreItems
            // 
            this.btnMoreItems.Location = new System.Drawing.Point(272, 48);
            this.btnMoreItems.Name = "btnMoreItems";
            this.btnMoreItems.Size = new System.Drawing.Size(84, 23);
            this.btnMoreItems.TabIndex = 7;
            this.btnMoreItems.Text = "More items";
            this.btnMoreItems.UseVisualStyleBackColor = true;
            this.btnMoreItems.Click += new System.EventHandler(this.btnMoreItems_Click);
            // 
            // TargetClassPage
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TargetClassPage";
            this.Size = new System.Drawing.Size(476, 252);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.TargetClassPage_SetActive);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Banner, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstTargetClasses;
        private System.Windows.Forms.ColumnHeader classNames;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMoreItems;
    }
}
