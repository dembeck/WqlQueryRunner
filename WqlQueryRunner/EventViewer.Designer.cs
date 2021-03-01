namespace WqlQueryRunner
{
    partial class EventViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewer));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openControlPanelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richEventReceiver = new System.Windows.Forms.RichTextBox();
            this.saveTextDialog = new System.Windows.Forms.SaveFileDialog();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openControlPanelMenuItem,
            this.toolStripSeparator2,
            this.copyToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator3,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.minimizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.ShowImageMargin = false;
            this.contextMenu.Size = new System.Drawing.Size(168, 242);
            // 
            // openControlPanelMenuItem
            // 
            this.openControlPanelMenuItem.Name = "openControlPanelMenuItem";
            this.openControlPanelMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openControlPanelMenuItem.Text = "Open Query Manager";
            this.openControlPanelMenuItem.Click += new System.EventHandler(this.openControlPanelMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.copyToolStripMenuItem.Text = "Copy text to clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveToolStripMenuItem.Text = "Save text to file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // richEventReceiver
            // 
            this.richEventReceiver.BackColor = global::WqlQueryRunner.Properties.Settings.Default.EventViewer_BackColor;
            this.richEventReceiver.ContextMenuStrip = this.contextMenu;
            this.richEventReceiver.Cursor = System.Windows.Forms.Cursors.Default;
            this.richEventReceiver.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::WqlQueryRunner.Properties.Settings.Default, "EventViewer_Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richEventReceiver.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::WqlQueryRunner.Properties.Settings.Default, "EventViewer_ForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richEventReceiver.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::WqlQueryRunner.Properties.Settings.Default, "EventViewer_BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richEventReceiver.DetectUrls = false;
            this.richEventReceiver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEventReceiver.Font = global::WqlQueryRunner.Properties.Settings.Default.EventViewer_Font;
            this.richEventReceiver.ForeColor = global::WqlQueryRunner.Properties.Settings.Default.EventViewer_ForeColor;
            this.richEventReceiver.HideSelection = false;
            this.richEventReceiver.Location = new System.Drawing.Point(0, 0);
            this.richEventReceiver.Name = "richEventReceiver";
            this.richEventReceiver.Size = new System.Drawing.Size(256, 125);
            this.richEventReceiver.TabIndex = 1;
            this.richEventReceiver.Text = "";
            this.richEventReceiver.WordWrap = false;
            this.richEventReceiver.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richEventReceiver_MouseUp);
            this.richEventReceiver.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richEventReceiver_MouseMove);
            this.richEventReceiver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richEventReceiver_MouseDown);
            // 
            // saveTextDialog
            // 
            this.saveTextDialog.DefaultExt = "txt";
            this.saveTextDialog.Filter = "txt files|*.txt";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.clearToolStripMenuItem.Text = "Clear text";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // EventViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::WqlQueryRunner.Properties.Settings.Default.EventViewer_BackColor;
            this.ClientSize = global::WqlQueryRunner.Properties.Settings.Default.EventViewer_Size;
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.richEventReceiver);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::WqlQueryRunner.Properties.Settings.Default, "EventViewer_BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Opacity", global::WqlQueryRunner.Properties.Settings.Default, "EventViewer_Opacity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::WqlQueryRunner.Properties.Settings.Default, "EventViewer_Size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventViewer";
            this.Opacity = global::WqlQueryRunner.Properties.Settings.Default.EventViewer_Opacity;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Viewer";
            this.Load += new System.EventHandler(this.EventViewer_Load);
            this.Resize += new System.EventHandler(this.EventViewer_Resize);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openControlPanelMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.RichTextBox richEventReceiver;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveTextDialog;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

