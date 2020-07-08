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
using System.Windows.Threading;

namespace PW_01
{
    public partial class MainForm : Form
    {
        private Process[] pc_arr;
        private int update_time = 10; // => set timer for updater thread
        private Thread upThread; // => created new thread
        private Dispatcher p = Dispatcher.CurrentDispatcher; // => get current thread (main thread)
        private bool hide = false;

        private string[] headers =
        {
            "PID",
            "Name",
            "Virtual Memory"
        };
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            pc_arr = Process.GetProcesses(); // => get current processes
            CreateColumns(); // => created columns header
            upThread = new Thread(new ThreadStart(Updater)); // => started new thread for updater processes
            upThread.Start(); // => run thread
            updateTimer();
        }

        private void CreateColumns()
        {
            foreach (var item in headers) proccess_dg.Columns.Add(item, item);
        }

        private async void UpdaterAsync() => await Task.Run(() => Updater());

        private void Updater()
        {
            
            while(true)
            {
                p.Invoke(
                    DispatcherPriority.Normal,
                    new Action(() =>
                    {
                        proccess_dg.Rows.Clear();
                    }));

                pc_arr = Process.GetProcesses();
                try
                {
                    foreach (Process pc in pc_arr)
                    {
                        if (pc.ProcessName == "svchost" || pc.ProcessName == "Idle" && hide) continue;
                        p.Invoke(
                            DispatcherPriority.Normal,
                            new Action(() =>
                            {
                                proccess_dg.Rows.Add(pc.Id, pc.ProcessName, pc.VirtualMemorySize64 / 1024 / 1024);
                            }));
                    }
                }
                catch { }
                Thread.Sleep(update_time*1000);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            upThread.Abort();
        }

        private void updateTimer() => current_time_tb.Text = update_time + " sec";

        private void up_Click(object sender, EventArgs e)
        {
            update_time = update_time + 1 >= 60 ? 60 : update_time + 1;
            updateTimer();
        }

        private void down_Click(object sender, EventArgs e)
        {
            update_time = update_time - 1 <= 3 ? 3 : update_time - 1;
            updateTimer();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) => hide = checkBox1.Checked;

        private void proccess_dg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Process p = Process.GetProcessById((int)proccess_dg.Rows[e.RowIndex].Cells[0].Value);
            Process[] pcopy = Process.GetProcessesByName(p.ProcessName);
            info1.Text = "PID: " + p.Id;
            info2.Text = "PTIME: " + p.TotalProcessorTime.TotalSeconds.ToString();
            info3.Text = string.Format("{0}:{1}:{2}", p.StartTime.Hour, p.StartTime.Minute, p.StartTime.Second);
            info4.Text = p.Threads.Count.ToString();
            info5.Text = "COPIES: " + pcopy.Length;
        }
    }
}
