namespace WqlQueryRunner
{
    partial class UserSettings
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabEventViewer = new System.Windows.Forms.TabPage();
            this.groupAppearence = new System.Windows.Forms.GroupBox();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.numericOpacity = new System.Windows.Forms.NumericUpDown();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.tabPopupWindow = new System.Windows.Forms.TabPage();
            this.numericPopupTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblPopupTimeout = new System.Windows.Forms.Label();
            this.lblPopWindoOpacity = new System.Windows.Forms.Label();
            this.numericPopupOpacity = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.fontPicker = new System.Windows.Forms.FontDialog();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.checkPopupWindow = new System.Windows.Forms.CheckBox();
            this.tabSettings.SuspendLayout();
            this.tabEventViewer.SuspendLayout();
            this.groupAppearence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOpacity)).BeginInit();
            this.tabPopupWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopupTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopupOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabEventViewer);
            this.tabSettings.Controls.Add(this.tabPopupWindow);
            this.tabSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(459, 285);
            this.tabSettings.TabIndex = 0;
            // 
            // tabEventViewer
            // 
            this.tabEventViewer.BackColor = System.Drawing.SystemColors.Control;
            this.tabEventViewer.Controls.Add(this.groupAppearence);
            this.tabEventViewer.Location = new System.Drawing.Point(4, 24);
            this.tabEventViewer.Name = "tabEventViewer";
            this.tabEventViewer.Padding = new System.Windows.Forms.Padding(3);
            this.tabEventViewer.Size = new System.Drawing.Size(451, 257);
            this.tabEventViewer.TabIndex = 0;
            this.tabEventViewer.Text = "Event Viewer";
            // 
            // groupAppearence
            // 
            this.groupAppearence.Controls.Add(this.numericHeight);
            this.groupAppearence.Controls.Add(this.numericWidth);
            this.groupAppearence.Controls.Add(this.lblHeight);
            this.groupAppearence.Controls.Add(this.btnColor);
            this.groupAppearence.Controls.Add(this.lblColor);
            this.groupAppearence.Controls.Add(this.lblWidth);
            this.groupAppearence.Controls.Add(this.btnFont);
            this.groupAppearence.Controls.Add(this.numericOpacity);
            this.groupAppearence.Controls.Add(this.lblFont);
            this.groupAppearence.Controls.Add(this.lblOpacity);
            this.groupAppearence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupAppearence.ForeColor = System.Drawing.Color.Black;
            this.groupAppearence.Location = new System.Drawing.Point(8, 6);
            this.groupAppearence.Name = "groupAppearence";
            this.groupAppearence.Size = new System.Drawing.Size(209, 193);
            this.groupAppearence.TabIndex = 0;
            this.groupAppearence.TabStop = false;
            this.groupAppearence.Text = "Appearence";
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(106, 112);
            this.numericHeight.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(68, 21);
            this.numericHeight.TabIndex = 4;
            this.numericHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericHeight.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericHeight.ValueChanged += new System.EventHandler(this.numericHeight_ValueChanged);
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(106, 90);
            this.numericWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(68, 21);
            this.numericWidth.TabIndex = 7;
            this.numericWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericWidth.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(38, 114);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(43, 15);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(106, 53);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(68, 23);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Change ...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(42, 58);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(38, 92);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 15);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(106, 145);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(68, 23);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "Change ...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // numericOpacity
            // 
            this.numericOpacity.DecimalPlaces = 2;
            this.numericOpacity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericOpacity.Location = new System.Drawing.Point(106, 27);
            this.numericOpacity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericOpacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericOpacity.Name = "numericOpacity";
            this.numericOpacity.Size = new System.Drawing.Size(68, 21);
            this.numericOpacity.TabIndex = 3;
            this.numericOpacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericOpacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericOpacity.ValueChanged += new System.EventHandler(this.numericOpacity_ValueChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(38, 150);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(31, 15);
            this.lblFont.TabIndex = 2;
            this.lblFont.Text = "Font";
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(38, 27);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(47, 15);
            this.lblOpacity.TabIndex = 0;
            this.lblOpacity.Text = "Opacity";
            // 
            // tabPopupWindow
            // 
            this.tabPopupWindow.BackColor = System.Drawing.SystemColors.Control;
            this.tabPopupWindow.Controls.Add(this.checkPopupWindow);
            this.tabPopupWindow.Controls.Add(this.numericPopupTimeout);
            this.tabPopupWindow.Controls.Add(this.lblPopupTimeout);
            this.tabPopupWindow.Controls.Add(this.lblPopWindoOpacity);
            this.tabPopupWindow.Controls.Add(this.numericPopupOpacity);
            this.tabPopupWindow.Location = new System.Drawing.Point(4, 24);
            this.tabPopupWindow.Name = "tabPopupWindow";
            this.tabPopupWindow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopupWindow.Size = new System.Drawing.Size(451, 257);
            this.tabPopupWindow.TabIndex = 1;
            this.tabPopupWindow.Text = "Popup Window";
            // 
            // numericPopupTimeout
            // 
            this.numericPopupTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericPopupTimeout.Location = new System.Drawing.Point(178, 88);
            this.numericPopupTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPopupTimeout.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericPopupTimeout.Name = "numericPopupTimeout";
            this.numericPopupTimeout.Size = new System.Drawing.Size(88, 21);
            this.numericPopupTimeout.TabIndex = 3;
            this.numericPopupTimeout.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericPopupTimeout.ValueChanged += new System.EventHandler(this.numericPopupTimeout_ValueChanged);
            // 
            // lblPopupTimeout
            // 
            this.lblPopupTimeout.AutoSize = true;
            this.lblPopupTimeout.Location = new System.Drawing.Point(26, 90);
            this.lblPopupTimeout.Name = "lblPopupTimeout";
            this.lblPopupTimeout.Size = new System.Drawing.Size(134, 15);
            this.lblPopupTimeout.TabIndex = 2;
            this.lblPopupTimeout.Text = "Popup Window timeout";
            // 
            // lblPopWindoOpacity
            // 
            this.lblPopWindoOpacity.AutoSize = true;
            this.lblPopWindoOpacity.Location = new System.Drawing.Point(26, 57);
            this.lblPopWindoOpacity.Name = "lblPopWindoOpacity";
            this.lblPopWindoOpacity.Size = new System.Drawing.Size(131, 15);
            this.lblPopWindoOpacity.TabIndex = 1;
            this.lblPopWindoOpacity.Text = "Popup Window opacity";
            // 
            // numericPopupOpacity
            // 
            this.numericPopupOpacity.DecimalPlaces = 2;
            this.numericPopupOpacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericPopupOpacity.Location = new System.Drawing.Point(178, 55);
            this.numericPopupOpacity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPopupOpacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericPopupOpacity.Name = "numericPopupOpacity";
            this.numericPopupOpacity.Size = new System.Drawing.Size(88, 21);
            this.numericPopupOpacity.TabIndex = 0;
            this.numericPopupOpacity.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericPopupOpacity.ValueChanged += new System.EventHandler(this.numericPopupOpacity_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(291, 291);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Color = System.Drawing.Color.Blue;
            // 
            // fontPicker
            // 
            this.fontPicker.Color = System.Drawing.Color.Yellow;
            this.fontPicker.FontMustExist = true;
            this.fontPicker.ScriptsOnly = true;
            this.fontPicker.ShowColor = true;
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.Location = new System.Drawing.Point(12, 291);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(117, 23);
            this.btnRestoreDefaults.TabIndex = 8;
            this.btnRestoreDefaults.Text = "Restore defaults";
            this.btnRestoreDefaults.UseVisualStyleBackColor = true;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // checkPopupWindow
            // 
            this.checkPopupWindow.AutoSize = true;
            this.checkPopupWindow.Checked = global::WqlQueryRunner.Properties.Settings.Default.Popup_Show;
            this.checkPopupWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPopupWindow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WqlQueryRunner.Properties.Settings.Default, "Popup_Show", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkPopupWindow.Location = new System.Drawing.Point(29, 21);
            this.checkPopupWindow.Name = "checkPopupWindow";
            this.checkPopupWindow.Size = new System.Drawing.Size(145, 19);
            this.checkPopupWindow.TabIndex = 4;
            this.checkPopupWindow.Text = "Warn me about errors";
            this.checkPopupWindow.UseVisualStyleBackColor = true;
            this.checkPopupWindow.CheckedChanged += new System.EventHandler(this.checkPopupWindow_CheckedChanged);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 322);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnRestoreDefaults);
            this.Controls.Add(this.btnApply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WQL Query Runner Settings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.tabSettings.ResumeLayout(false);
            this.tabEventViewer.ResumeLayout(false);
            this.groupAppearence.ResumeLayout(false);
            this.groupAppearence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOpacity)).EndInit();
            this.tabPopupWindow.ResumeLayout(false);
            this.tabPopupWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopupTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopupOpacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabEventViewer;
        private System.Windows.Forms.TabPage tabPopupWindow;
        private System.Windows.Forms.GroupBox groupAppearence;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.NumericUpDown numericOpacity;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.FontDialog fontPicker;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Button btnRestoreDefaults;
        private System.Windows.Forms.NumericUpDown numericPopupTimeout;
        private System.Windows.Forms.Label lblPopupTimeout;
        private System.Windows.Forms.Label lblPopWindoOpacity;
        private System.Windows.Forms.NumericUpDown numericPopupOpacity;
        private System.Windows.Forms.CheckBox checkPopupWindow;
    }
}