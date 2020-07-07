using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadTest
{
    public partial class ProcessInfo : Form
    {
        private int processId;
        Process process;
        Thread updater;

        public ProcessInfo(int processId)
        {
            this.processId = processId;
            InitializeComponent();
            updater = new Thread(new ThreadStart(updateInfo));
            updater.Start();
        }

        private void updateInfo()
        {
            try
            {
                process = Process.GetProcessById(processId);
                info1.Text = process.Id.ToString();
                info2.Text = process.ProcessName;
                info3.Text = process.Handle.ToString() + " Handle";
                info4.Text = process.VirtualMemorySize64 / 1024 / 1024 + " Mb";
                info5.Text = process.Modules.Count + " Modules";
                info6.Text = process.MainModule.ModuleName;
            }
            catch { }
            Thread.Sleep(5000);
        }

        private void ProcessInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            updater.Abort();
        }

        private void close_Click(object sender, EventArgs e)
        {
            process.Kill();
            Close();
        }
    }
}
