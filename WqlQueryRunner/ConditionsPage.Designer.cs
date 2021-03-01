namespace WqlQueryRunner
{
    partial class ConditionsPage
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lstProperties = new System.Windows.Forms.ListView();
            this.propertyNames = new System.Windows.Forms.ColumnHeader();
            this.groupOperators = new System.Windows.Forms.GroupBox();
            this.radioLike = new System.Windows.Forms.RadioButton();
            this.radioLessEquals = new System.Windows.Forms.RadioButton();
            this.radioLess = new System.Windows.Forms.RadioButton();
            this.radioGreaterEquals = new System.Windows.Forms.RadioButton();
            this.radioGreater = new System.Windows.Forms.RadioButton();
            this.radioEquals = new System.Windows.Forms.RadioButton();
            this.comboValues = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Size = new System.Drawing.Size(535, 28);
            this.Banner.Subtitle = "";
            this.Banner.Title = "Filter the Events to Receive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "\r\nFilter the events you want to receive. ";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(20, 68);
            this.lblText.MaximumSize = new System.Drawing.Size(350, 60);
            this.lblText.MinimumSize = new System.Drawing.Size(520, 40);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(520, 40);
            this.lblText.TabIndex = 2;
            // 
            // txtCondition
            // 
            this.txtCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(256, 152);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(188, 76);
            this.txtCondition.TabIndex = 8;
            // 
            // lstProperties
            // 
            this.lstProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.propertyNames});
            this.lstProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProperties.FullRowSelect = true;
            this.lstProperties.GridLines = true;
            this.lstProperties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstProperties.HideSelection = false;
            this.lstProperties.Location = new System.Drawing.Point(16, 120);
            this.lstProperties.MultiSelect = false;
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(172, 108);
            this.lstProperties.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstProperties.TabIndex = 9;
            this.lstProperties.UseCompatibleStateImageBehavior = false;
            this.lstProperties.View = System.Windows.Forms.View.Details;
            this.lstProperties.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstProperties_ItemSelectionChanged);
            // 
            // propertyNames
            // 
            this.propertyNames.Width = 150;
            // 
            // groupOperators
            // 
            this.groupOperators.Controls.Add(this.radioLike);
            this.groupOperators.Controls.Add(this.radioLessEquals);
            this.groupOperators.Controls.Add(this.radioLess);
            this.groupOperators.Controls.Add(this.radioGreaterEquals);
            this.groupOperators.Controls.Add(this.radioGreater);
            this.groupOperators.Controls.Add(this.radioEquals);
            this.groupOperators.Location = new System.Drawing.Point(196, 116);
            this.groupOperators.Name = "groupOperators";
            this.groupOperators.Size = new System.Drawing.Size(56, 116);
            this.groupOperators.TabIndex = 7;
            this.groupOperators.TabStop = false;
            // 
            // radioLike
            // 
            this.radioLike.AutoSize = true;
            this.radioLike.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLike.Location = new System.Drawing.Point(0, 92);
            this.radioLike.MinimumSize = new System.Drawing.Size(62, 0);
            this.radioLike.Name = "radioLike";
            this.radioLike.Size = new System.Drawing.Size(62, 20);
            this.radioLike.TabIndex = 5;
            this.radioLike.TabStop = true;
            this.radioLike.Text = "  Like";
            this.radioLike.UseVisualStyleBackColor = true;
            this.radioLike.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioLessEquals
            // 
            this.radioLessEquals.AutoSize = true;
            this.radioLessEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioLessEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioLessEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLessEquals.Location = new System.Drawing.Point(0, 76);
            this.radioLessEquals.MinimumSize = new System.Drawing.Size(60, 0);
            this.radioLessEquals.Name = "radioLessEquals";
            this.radioLessEquals.Size = new System.Drawing.Size(60, 20);
            this.radioLessEquals.TabIndex = 4;
            this.radioLessEquals.TabStop = true;
            this.radioLessEquals.Text = "  <=";
            this.radioLessEquals.UseVisualStyleBackColor = true;
            this.radioLessEquals.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioLess
            // 
            this.radioLess.AutoSize = true;
            this.radioLess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLess.Location = new System.Drawing.Point(0, 60);
            this.radioLess.MinimumSize = new System.Drawing.Size(62, 0);
            this.radioLess.Name = "radioLess";
            this.radioLess.Size = new System.Drawing.Size(62, 20);
            this.radioLess.TabIndex = 3;
            this.radioLess.TabStop = true;
            this.radioLess.Text = "  <";
            this.radioLess.UseVisualStyleBackColor = true;
            this.radioLess.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioGreaterEquals
            // 
            this.radioGreaterEquals.AutoSize = true;
            this.radioGreaterEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioGreaterEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioGreaterEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGreaterEquals.Location = new System.Drawing.Point(0, 44);
            this.radioGreaterEquals.MinimumSize = new System.Drawing.Size(62, 0);
            this.radioGreaterEquals.Name = "radioGreaterEquals";
            this.radioGreaterEquals.Size = new System.Drawing.Size(62, 20);
            this.radioGreaterEquals.TabIndex = 2;
            this.radioGreaterEquals.TabStop = true;
            this.radioGreaterEquals.Text = "  >=";
            this.radioGreaterEquals.UseVisualStyleBackColor = true;
            this.radioGreaterEquals.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioGreater
            // 
            this.radioGreater.AutoSize = true;
            this.radioGreater.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioGreater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGreater.Location = new System.Drawing.Point(0, 28);
            this.radioGreater.MinimumSize = new System.Drawing.Size(62, 0);
            this.radioGreater.Name = "radioGreater";
            this.radioGreater.Size = new System.Drawing.Size(62, 20);
            this.radioGreater.TabIndex = 1;
            this.radioGreater.TabStop = true;
            this.radioGreater.Text = "  >";
            this.radioGreater.UseVisualStyleBackColor = true;
            this.radioGreater.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioEquals
            // 
            this.radioEquals.AutoSize = true;
            this.radioEquals.Checked = true;
            this.radioEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEquals.Location = new System.Drawing.Point(0, 12);
            this.radioEquals.MinimumSize = new System.Drawing.Size(62, 0);
            this.radioEquals.Name = "radioEquals";
            this.radioEquals.Size = new System.Drawing.Size(62, 20);
            this.radioEquals.TabIndex = 0;
            this.radioEquals.TabStop = true;
            this.radioEquals.Text = "  =";
            this.radioEquals.UseVisualStyleBackColor = true;
            this.radioEquals.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // comboValues
            // 
            this.comboValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboValues.FormattingEnabled = true;
            this.comboValues.Location = new System.Drawing.Point(256, 120);
            this.comboValues.Name = "comboValues";
            this.comboValues.Size = new System.Drawing.Size(189, 23);
            this.comboValues.Sorted = true;
            this.comboValues.TabIndex = 10;
            this.comboValues.TextChanged += new System.EventHandler(this.comboValues_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(452, 152);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(452, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ConditionsPage
            // 
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.comboValues);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.groupOperators);
            this.Name = "ConditionsPage";
            this.Size = new System.Drawing.Size(535, 243);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.ConditionsPage_SetActive);
            this.Controls.SetChildIndex(this.groupOperators, 0);
            this.Controls.SetChildIndex(this.txtCondition, 0);
            this.Controls.SetChildIndex(this.comboValues, 0);
            this.Controls.SetChildIndex(this.lblText, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.lstProperties, 0);
            this.Controls.SetChildIndex(this.Banner, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.groupOperators.ResumeLayout(false);
            this.groupOperators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ListView lstProperties;
        private System.Windows.Forms.ColumnHeader propertyNames;
        private System.Windows.Forms.GroupBox groupOperators;
        private System.Windows.Forms.RadioButton radioLike;
        private System.Windows.Forms.RadioButton radioLessEquals;
        private System.Windows.Forms.RadioButton radioLess;
        private System.Windows.Forms.RadioButton radioGreaterEquals;
        private System.Windows.Forms.RadioButton radioGreater;
        private System.Windows.Forms.RadioButton radioEquals;
        private System.Windows.Forms.ComboBox comboValues;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClear;
    }
}
