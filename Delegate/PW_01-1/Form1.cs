using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_01_1
{
    public partial class Form1 : Form
    {
        private string executeFilePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void paintStart_btn_Click(object sender, EventArgs e) => Process.Start("mspaint.exe");

        private void calcStart_btn_Click(object sender, EventArgs e) => Process.Start("calc.exe");

        private void notepadStart_Btn_Click(object sender, EventArgs e) => Process.Start("notepad.exe");

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "exe files (*.exe)|*.exe";
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                processPath_tb.Text = dialog.FileName;
                executeFilePath = processPath_tb.Text;
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(executeFilePath)) return;
            try
            {
                Process.Start(executeFilePath);
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
