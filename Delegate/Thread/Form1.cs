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
    public partial class Form1 : Form
    {
        DataTable ds = new DataTable();
        Process[] processes;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                dg.DataSource = ds;
                ds.Columns.Add("PID");
                ds.Columns.Add("Process Name");
                ds.Columns.Add("Memory");
                ds.Columns.Add("Handle");
                processes = Process.GetProcesses();
                foreach (var item in processes)
                {
                    try
                    {
                        DataRow dr = ds.Rows.Add(item.Id, item.ProcessName, item.VirtualMemorySize64 / 1024 / 1024, item.Handle);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int p = int.Parse(ds.Rows[e.RowIndex].ItemArray[0].ToString());
            ProcessInfo pi = new ProcessInfo(p);
            pi.ShowDialog();
        }
    }
}
