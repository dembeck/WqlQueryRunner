using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management;
using System.Text;
using System.Diagnostics;

namespace WqlQueryRunner
{
    // Should sometimes change this class
    // to inherit from WqlEventQuery

    public class MonitoringItem : IDisposable
    {
        #region PrivateMembers

        private string mName;
        private string mScope;
        //public string monitoredClass;

        private ManagementEventWatcher Watcher = new ManagementEventWatcher();
        private WqlEventQuery mWqlQuery = new WqlEventQuery();

        private Dictionary<string, EventAction> mActions =
            new Dictionary<string,EventAction>();

        public MonitoringItemState State = MonitoringItemState.Undefined;

        // To get to the dictionary

        #endregion

        #region Constructors

        public MonitoringItem(string wqlQuery, string name)
        {
            Name = name;
            WqlQuery.QueryString = wqlQuery;
        }

        public MonitoringItem(WqlEventQuery query, string name)
        {
            WqlQuery = query;
            Name = name;
        }

        public MonitoringItem(string scope, string wqlQuery, string name)
        {
            Watcher.Scope = new ManagementScope(scope);
            WqlQuery.QueryString = wqlQuery;
            Name = name;
        }

        #endregion

        #region Public Properties

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public WqlEventQuery WqlQuery
        {
            get
            {
                return mWqlQuery;
            }
            set
            {
                mWqlQuery = value;
            }
        }

        public string Scope
        {
            get
            {
                return mScope;
            }
            set
            {
                mScope = value;
            }
        }

        public Dictionary<string, EventAction> Actions
        {
            get
            {
                return mActions;
            }
            set
            {
                mActions = value;
            }
        }
   

        // TODO: remove this?

        #endregion

        #region Start - Stop Monitoring

        public void StartMonitoring()
        {
            try
            {
                Watcher.Query = WqlQuery;
                Watcher.EventArrived +=
                    new EventArrivedEventHandler(watcherEventHandler);
                Watcher.Start();
                State = MonitoringItemState.Running;
            }
            catch (ManagementException e)
            {
                State = MonitoringItemState.Undefined;
                throw e;
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                State = MonitoringItemState.Undefined;

                if ((uint)e.ErrorCode >= 0x80041001 | 
                    (uint)e.ErrorCode <= 0x80044031)
                {
                    // TODO: Add code to return XML documentation
                    // Summary field for the corresponding 
                    // System.Management.ManagementStatus enum

                    throw new ManagementException(
                        ((ManagementStatus)e.ErrorCode).ToString());
                }
            }
        }

        public void StopMonitoring()
        {
            try
            {
                Watcher.Stop();
                Watcher.EventArrived -= watcherEventHandler;
                State = MonitoringItemState.Stopped;
            }
            catch
            {
                State = MonitoringItemState.Undefined;
            }
        }

        #endregion

        #region Event Related

        private void watcherEventHandler(
            object sender, EventArrivedEventArgs e)
        {
            WmiEventReceivedEventArgs ex = new WmiEventReceivedEventArgs(
                (ManagementBaseObject)e.NewEvent["TargetInstance"], null);

            OnWmiEventReceived(ex);
        }

        public event WmiEventReceivedHandler WmiEventReceived;

        // call this whenever the 
        // ManagementEventWatcher.EventArrived is fired

        protected virtual void OnWmiEventReceived(
            WmiEventReceivedEventArgs e)
        {
            if (WmiEventReceived != null)
            {
                WmiEventReceived(this, e);
            }
        }

        #endregion

        #region Cleanup

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Watcher.Stop();
                Watcher.EventArrived -= watcherEventHandler;
                State = MonitoringItemState.Stopped;
            }
        }

        ~MonitoringItem()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }

        #endregion
    }

    public class WmiEventReceivedEventArgs : System.EventArgs
    {
        #region Private Members

        private ManagementBaseObject TargetInst;
        private ManagementBaseObject PreviousInst;

        #endregion

        #region Constructors

        private WmiEventReceivedEventArgs()
        { 
        }

        public WmiEventReceivedEventArgs(
            ManagementBaseObject targetInst, 
            ManagementBaseObject previousInst)
        {
            this.TargetInst = targetInst;
            this.PreviousInst = previousInst;
        }

        #endregion

        #region Public Properties

        public ManagementBaseObject TargetInstance
        {
            get
            {
                return TargetInst;
            }
        }

        public ManagementBaseObject PreviousInstance
        {
            get
            {
                return PreviousInst;
            }
        }

        #endregion
    }

    public class EventAction
    {
        private string mName;
        private MonitoringItem mParent;
        private EventActionState mState = 
            EventActionState.Inactive;

        private uint mInstanceCount = 0;
        private uint mInstanceLimit = 1;
        private bool mLimitInstances = true;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public MonitoringItem Parent
        {
            get
            {
                return mParent;
            }
            set
            {
                mParent = value;
            }
        }

        public EventActionState State
        {
            get
            {
                return mState;
            }
            set
            {
                mState = value;
            }
        }

        public virtual uint InstanceCount
        {
            get
            {
                return mInstanceCount;
            }
            set
            {
                mInstanceCount = value;
            }
        }

        public virtual uint InstanceLimit
        {
            get
            {
                return mInstanceLimit;
            }
            set
            {
                mInstanceLimit = value;
            }
        }

        public virtual bool LimitInstances
        {
            get
            {
                return mLimitInstances;
            }
            set
            {
                mLimitInstances = value;
            }
        }

        public EventAction(MonitoringItem item)
        {
            mParent = item;
        }

        public virtual void Execute(
            ManagementBaseObject targetInstance, 
            ManagementBaseObject previousInstance)
        {}

        public virtual void Handler(object sender, EventArgs e)
        {
            InstanceCount--;
        }
    }

    public class GetEventTextAction : EventAction
    {
        public GetEventTextAction(MonitoringItem item): base(item)
        {}

        public string GetEventText(
            ManagementBaseObject TargetInstance, 
            ManagementBaseObject PreviousInstance)
        {
            StringBuilder name = new StringBuilder("");

            foreach (PropertyData property in TargetInstance.Properties)
            {
                if (property.Name.ToLower() == "name")
                {
                    name.Insert(0, "Name : ");
                    name.Insert(7, property.Value.ToString() +
                        Environment.NewLine);
                }
                foreach (QualifierData qualifier in property.Qualifiers)
                {
                    if (qualifier.Name.ToLower() == "key")
                    {
                        name.Append(property.Name);
                        name.Append(" : ");
                        name.Append(property.Value.ToString());
                        name.AppendLine();
                    }
                }
            }

            if (name.Length == 0)
            {
                return TargetInstance.ClassPath.RelativePath +
                    Environment.NewLine;
            }
            else
            {
                return name.ToString();
            }
        }

        public override void Execute(
            ManagementBaseObject targetInstance, 
            ManagementBaseObject previousInstance)
        {}
    }

    public class ActiveScriptAction : EventAction
    {
        public ActiveScriptAction(
            MonitoringItem item): base(item)
        {}

        public ActiveScriptAction(
            MonitoringItem item, string scriptPath)
            : base(item)
        {
            ScriptFileName = scriptPath;
        }

        private uint mKillTimeOut;
        private uint mMaximumQueSize;
        private string mScriptFileName;
        private string mScriptHost = "cscript.exe";
        private string mScriptText = null;
        private string mScriptingEngine = null;

        private Process process = new Process();

        public UInt32 KillTimeout
        {
            get
            {
                return mKillTimeOut;
            }
            set
            {
                mKillTimeOut = value;
            }
        }

        public UInt32 MaximumQueSize
        {
            get
            {
                return mMaximumQueSize;
            }
            set
            {
                mMaximumQueSize = value;
            }
        }

        public string ScriptFileName
        {
            get
            {
                return mScriptFileName;
            }
            set
            {
                mScriptFileName = value;
            }
        }

        public string ScriptHost
        {
            get
            {
                return mScriptHost;
            }
            set
            {
                if (value.ToLower() == "cscript.exe" |
                    value.ToLower() == "wscript.exe")
                {
                    mScriptHost = value;
                }
            }
        }

        public string ScriptText
        {
            get
            {
                return mScriptText;
            }
            set
            {
                mScriptText = value;
            }
        }

        public string ScriptingEngine
        {
            get
            {
                return mScriptingEngine;
            }
            set
            {
                mScriptingEngine = value;
            }
        }

        /*public override uint InstanceCount
        {
            get
            {
                return base.InstanceCount;
            }
            set
            {
                base.InstanceCount = value;
            }
        }*/

        /*public override int InstanceLimit
        {
            get
            {
                return base.InstanceLimit;
            }
            set
            {
                base.InstanceLimit = value;
            }
        }*/

        public override void Handler(object sender, EventArgs e)
        {
            base.Handler(sender, e);
        }

        public override void Execute(
            ManagementBaseObject targetInstance, 
            ManagementBaseObject previousInstance)
        {
            if (File.Exists(ScriptFileName))
            {
                if (InstanceCount < InstanceLimit & LimitInstances)
                {
                    process = Process.Start(GetHostPath(),
                        "\"" + ScriptFileName + "\" " +
                        ToNamedArguments(targetInstance));

                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(Handler);

                    InstanceCount++;
                }
            }
            else
            {
                throw new FileNotFoundException(
                    "Script file not found", ScriptFileName);
            }
        }

        private string GetHostPath()
        {
            if (ScriptHost.ToLower() == "cscript.exe" &
                File.Exists(Environment.GetFolderPath(
                Environment.SpecialFolder.System) + "\\cscript.exe"))
            {
                return Environment.GetFolderPath(
                    Environment.SpecialFolder.System) + "\\cscript.exe";
            }
            else if (File.Exists(Environment.GetFolderPath(
                Environment.SpecialFolder.System) + "\\wscript.exe"))
            {
                return Environment.GetFolderPath(
                    Environment.SpecialFolder.System) + "\\wscript.exe";
            }
            else
            {
                return null;
            }
        }

        private string ToNamedArguments(
            ManagementBaseObject instance)
        {

            string retVal = "";

            foreach (PropertyData property in instance.Properties)
            {
                if (property.Value != null)
                {
                    retVal += ("/" + property.Name + ":" + "\"" + property.Value.ToString() + "\" ");
                }
                else
                {
                    retVal += ("/" + property.Name + ":" + "Null ");
                }

            }
            return retVal;
        }
    }

    public delegate void WmiEventReceivedHandler(
        object sender, WmiEventReceivedEventArgs e);

    // Monitoring item states

    public enum MonitoringItemState
    {
        Stopped,
        Running,
        Undefined,
        Incomplete
    }

    public enum EventActionState
    {
        Active, 
        Inactive,
        Error
    }
}
