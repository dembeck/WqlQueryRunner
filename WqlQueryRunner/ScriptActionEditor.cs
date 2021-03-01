using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class ScriptActionEditor : Form
    {
        private MonitoringItem Item;

        private bool Editing;

        public ScriptActionEditor()
        {
            InitializeComponent();
        }

        public ScriptActionEditor(MonitoringItem item, bool editing)
        {
            InitializeComponent();
            Item = item;
            lblScriptHost.Text = "cscript.exe";

            Editing = editing;

            if (Editing)
            {
                txtActionName.Enabled = false;
            }
        }

        private void btnBrowseForScript_Click(
            object sender, EventArgs e)
        {
            if (openScriptFile.ShowDialog() == DialogResult.OK)
            {
                txtScriptPath.Text = openScriptFile.FileName;
                DisplayScriptText(openScriptFile.FileName);
            }
        }

        private void radioCScript_CheckedChanged(
            object sender, EventArgs e)
        {
            if (((sender as RadioButton).Checked))
            {
                lblScriptHost.Text = "cscript.exe";
            }
            else
            {
                lblScriptHost.Text = "wscript.exe";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(
            object sender, EventArgs e)
        {
            if (txtActionName.Text.Length > 0 &
                txtScriptPath.Text.Length > 0)
            {
                ActiveScriptAction action =
                    new ActiveScriptAction(Item);

                action.Name = txtActionName.Text;
                action.ScriptFileName = txtScriptPath.Text;
                action.ScriptHost = lblScriptHost.Text;

                if (checkLimitInstances.Checked)
                {
                    action.LimitInstances = true;
                }
                else
                {
                    action.LimitInstances = false;
                }

                action.InstanceLimit = Convert.ToUInt32(
                    numericInstanceLimit.Value);

                if (!Editing)
                {
                    if (!Item.Actions.ContainsKey(action.Name))
                    {
                        Item.Actions.Add(action.Name, action);
                    }
                    else
                    {
                        MessageBox.Show("A monitoring action " +
                            "with that name already exists");
                    }
                }
                else
                {
                    (Item.Actions[txtActionName.Text]
                        as ActiveScriptAction).ScriptFileName = txtScriptPath.Text;
                    (Item.Actions[txtActionName.Text]
                        as ActiveScriptAction).ScriptHost = lblScriptHost.Text;
                    (Item.Actions[txtActionName.Text]
                        as ActiveScriptAction).InstanceLimit = Convert.ToUInt32(
                        numericInstanceLimit.Value);
                    if (checkLimitInstances.Checked)
                    {
                        (Item.Actions[txtActionName.Text]
                        as ActiveScriptAction).LimitInstances = true;
                    }
                    else
                    {
                        (Item.Actions[txtActionName.Text]
                            as ActiveScriptAction).LimitInstances = false;
                    }

                }

                Close();
            }
            else
            {
                if (MessageBox.Show("Both action name and script file path " +
                    Environment.NewLine + "must be entered." +
                    Environment.NewLine + "Do you want exit " +
                    "the Script action editor without saving?",
                    null, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        public void SetActionName(string name)
        {
            txtActionName.Text = name;
        }

        public void SetScriptingHost(string host)
        {
            if (host.ToLower() == "wscript.exe")
            {
                radioWScript.Checked = true;
            }

            if (host.ToLower() == "cscript.exe")
            {
                radioCScript.Checked = true;
            }
        }

        public void SetScriptFilePath(string path)
        {
            txtScriptPath.Text = path;
        }

        public void DisplayScriptText(string path)
        {
            if(System.IO.File.Exists(path))
            {
                txtScriptText.Text =
                    new System.IO.StreamReader(path).ReadToEnd();
            }
            else
            {
                txtScriptText.Text = 
                    "Unable to open the script" + 
                    Environment.NewLine +
                    "Please check the script file path";
            }
        }

        public void SetActionLimit(
            bool limitInstances, uint instanceLimit)
        {
            if (limitInstances)
            {
                checkLimitInstances.Checked = true;
            }
            else
            {
                checkLimitInstances.Checked = false;
            }
            numericInstanceLimit.Value = 
                Convert.ToDecimal(instanceLimit);
        }

        private void checkLimitInstances_CheckedChanged(
            object sender, EventArgs e)
        {
            if (checkLimitInstances.Checked)
            {
                numericInstanceLimit.Enabled = true;
            }
            else
            {
                numericInstanceLimit.Enabled = false;
            }
        }

        private void txtScriptPath_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DisplayScriptText(txtScriptPath.Text);
            }
        }
        
    }
}
