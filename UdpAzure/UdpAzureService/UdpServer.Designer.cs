﻿namespace UdpAzureService
{
    partial class UdpServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UdpEventLog = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.UdpEventLog)).BeginInit();
            // 
            // UdpEventLog
            // 
            this.UdpEventLog.Log = "Application";
            this.UdpEventLog.Source = "UdpEnventLog";
            // 
            // UdpServer
            // 
            this.ServiceName = "UdpServer";
            ((System.ComponentModel.ISupportInitialize)(this.UdpEventLog)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog UdpEventLog;
    }
}
