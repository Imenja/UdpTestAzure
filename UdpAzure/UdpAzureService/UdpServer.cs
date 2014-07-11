using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace UdpAzureService
{
    public partial class UdpServer : ServiceBase
    {
        public UdpServer()
        {
            InitializeComponent();
            UdpEventLog.Source = "UdpEnventLog";
            UdpEventLog.Log = "AzureUdpLog";
        }

        protected override void OnStart(string[] args)
        {
            UdpEventLog.WriteEntry("Starting Udp Service "+DateTime.Now);
        }

        protected override void OnStop()
        {
            UdpEventLog.WriteEntry("Stopping Udp Service "+DateTime.Now);
        }

        protected override void OnShutdown()
        {
            UdpEventLog.WriteEntry("Service Shutdown "+DateTime.Now);
            base.OnShutdown();
        }

    }
}
