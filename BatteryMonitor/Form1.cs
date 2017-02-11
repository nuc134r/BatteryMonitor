using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BatteryMonitor.Properties;
using Microsoft.Win32;

namespace BatteryMonitor
{
    public partial class Form1 : Form
    {
        private readonly NotifyIcon trayIcon;
        private PowerLineStatus lastStatus = SystemInformation.PowerStatus.PowerLineStatus;

        public Form1()
        {
            InitializeComponent();

            trayIcon = new NotifyIcon { Visible = false, Icon = SystemIcons.Information};
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SystemEvents.PowerModeChanged += OnPowerModeChanged;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SystemEvents.PowerModeChanged -= OnPowerModeChanged;
        }

        private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            var newStatus = SystemInformation.PowerStatus.PowerLineStatus;

            if (e.Mode == PowerModes.StatusChange && newStatus != lastStatus)
            {
                trayIcon.BalloonTipTitle = Resources.Form1_OnPowerModeChanged_Power_status_has_changed;

                switch (newStatus)
                {
                    case PowerLineStatus.Online:
                        DisablePowerSaving();

                        trayIcon.BalloonTipIcon = ToolTipIcon.None;
                        trayIcon.BalloonTipText = Resources.Form1_OnPowerModeChanged_Power_saving_is_disabled;

                        lastStatus = newStatus;
                        break;
                    case PowerLineStatus.Offline:
                        EnablePowerSaving();

                        trayIcon.BalloonTipIcon = ToolTipIcon.None;
                        trayIcon.BalloonTipText = Resources.Form1_OnPowerModeChanged_Power_saving_is_enabled;

                        lastStatus = newStatus;
                        break;
                    case PowerLineStatus.Unknown:
                        trayIcon.BalloonTipIcon = ToolTipIcon.Error;
                        trayIcon.BalloonTipText = Resources.Form1_OnPowerModeChanged_Problem_occured_determining_power_mode;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000);
                trayIcon.Visible = false;
            }
        }

        private void EnablePowerSaving()
        {
            RunCmdCommand("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a");
            
        }

        private void DisablePowerSaving()
        {
            RunCmdCommand("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
        }

        private void RunCmdCommand(string command)
        {
            var cmd = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }
    }
}