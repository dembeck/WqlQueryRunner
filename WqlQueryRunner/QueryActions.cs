using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class QueryActions : Form
    {
        public QueryManager Parent = new QueryManager();

        public QueryActions()
        {
            InitializeComponent();
        }

        public QueryActions(MonitoringItem item)
        {
            Item = item;
            InitializeComponent();
        }

        private MonitoringItem mItem;

        public MonitoringItem Item
        {
            get
            {
                return mItem;
            }
            set
            {
                mItem = value;
            }
        }

        private void UpdateItemActions()
        {
            foreach (EventAction action in Item.Actions.Values)
            {
                if (!lstEventActions.Items.ContainsKey(action.Name))
                {
                    lstEventActions.Items.Add(
                        action.Name, action.Name, null);

                    ListViewItem.ListViewSubItem subItem =
                        new ListViewItem.ListViewSubItem();
                    subItem.Name = "State";
                    subItem.Text = action.State.ToString();

                    lstEventActions.Items[action.Name].SubItems.Add(subItem);
                }
                else
                {
                    lstEventActions.Items[action.Name].SubItems["State"].Text =
                        action.State.ToString();
                }
            }
        }

        private void QueryActions_Load(object sender, EventArgs e)
        {
            UpdateItemActions();
        }

        private void btnScriptAction_Click(object sender, EventArgs e)
        {
            ScriptActionEditor editor =
                new ScriptActionEditor(Item, false);
            editor.ShowDialog();
            UpdateItemActions();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (lstEventActions.SelectedItems.Count == 1)
            {
                Item.Actions[lstEventActions.SelectedItems[0].Name].State
                   = EventActionState.Active;
                UpdateItemActions();
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (lstEventActions.SelectedItems.Count == 1)
            {
                Item.Actions[lstEventActions.SelectedItems[0].Name].State
                   = EventActionState.Inactive;
                UpdateItemActions();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstEventActions.SelectedItems.Count == 1)
            {
                Item.Actions.Remove(
                    lstEventActions.SelectedItems[0].Name);
                lstEventActions.SelectedItems[0].Remove();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lstEventActions.SelectedItems.Count == 1)
            {
                if (Item.Actions[lstEventActions.SelectedItems[0].Name]
                    is ActiveScriptAction)
                {
                    EventAction action =
                        Item.Actions[lstEventActions.SelectedItems[0].Name];

                    ActiveScriptAction scriptAction =
                        action as ActiveScriptAction;
                    
                    if (scriptAction != null)
                    {
                        ScriptActionEditor editor =
                            new ScriptActionEditor(Item, true);
                        editor.SetActionName(scriptAction.Name);
                        editor.SetScriptFilePath(scriptAction.ScriptFileName);
                        editor.SetScriptingHost(scriptAction.ScriptHost);
                        editor.DisplayScriptText(scriptAction.ScriptFileName);
                        editor.SetActionLimit(
                            scriptAction.LimitInstances, 
                            scriptAction.InstanceLimit);

                        editor.ShowDialog();
                    }
                }
            }
        }
    }
}
