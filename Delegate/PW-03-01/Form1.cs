using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_03_01
{
    // start 10 10
    // size 775, 23
    // increase 30
    public partial class MainForm : Form
    {
        private int pbCount = 0;
        private ProgressBar[] progressBars;
        private Thread[] threads;

        public MainForm()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            bool res = int.TryParse(progressBars_count_tb.Text, out pbCount);
            if (!res) return;
            if (pbCount > 12) pbCount = 12;

            progressBars = new ProgressBar[pbCount];
            threads = new Thread[pbCount];

            for (int i = 0; i < pbCount; i++)
            {
                progressBars[i] = new ProgressBar();
                progressBars[i].Location = new Point(10, 10 + (i * 30));
                progressBars[i].Size = new Size(775, 20);
                this.Controls.Add(progressBars[i]);
                threads[i] = new Thread(new ParameterizedThreadStart(DancePb));
                threads[i].Start(progressBars[i]);
            }
        }

        private void DancePb(object pb)
        {
            while(true)
            {
                Random r = new Random();
                Thread.Sleep(5);
                ProgressBar current = (ProgressBar)pb;
                Thread.Sleep(5);
                current.ForeColor = Color.FromArgb(r.Next(0,200), r.Next(0, 200), r.Next(0, 200), r.Next(0, 200));
                Thread.Sleep(5);
                current.Value = r.Next(0, 99);
                Thread.Sleep(5);
                int state = r.Next(1, 3);
                ModifyProgressBarColor.SetState(current, state);
                Thread.Sleep(r.Next(10, 100));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pbCount == 0) return;

            for (int i = 0; i < pbCount; i++)
            {
                threads[i].Abort();
            }
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
