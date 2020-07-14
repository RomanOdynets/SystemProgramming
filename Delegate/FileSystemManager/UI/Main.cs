using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileSystemManager.UI
{
    public partial class Main : Form
    {
        private DriveInfo[] drives = DriveInfo.GetDrives();
        private int CurrentIndex { get; set; } = -1;
        private string CurrentPath { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            foreach (var drive in drives)
            {
                if (!drive.IsReady) continue;
                driverVolume_cb.Items.Add(drive.Name);
            }

            driverVolume_cb.SelectedIndex = 0;
            driverVolume_cb_SelectedIndexChanged(null, null);
        }

        private void driverVolume_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (driverVolume_cb.SelectedIndex == CurrentIndex) return;

            fileSystem.Items.Clear();

            CurrentIndex = driverVolume_cb.SelectedIndex;

            CurrentPath = drives[CurrentIndex].Name;

            string[] dirs = Directory.GetDirectories(CurrentPath);
            string[] files = Directory.GetFiles(CurrentPath);

            foreach(string dir in dirs) fileSystem.Items.Add(dir);
            foreach (string file in files) fileSystem.Items.Add(file);
        }

        private void fileSystem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickName = (string)fileSystem.SelectedItem;

            bool IsFile = false;

            if (File.Exists(clickName)) IsFile = true;
            else if (Directory.Exists(clickName)) IsFile = false;

            if (IsFile)
            {
                try { Process.Start(clickName); }
                catch { }
                return;
            }

            if(clickName == "[...]")
            {
                string[] tmpPath = CurrentPath.Split('\\');

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < tmpPath.Length - 1; i++)
                {
                    if(i == tmpPath.Length-2 && tmpPath.Length != 2) sb.Append(tmpPath[i]);
                    else sb.Append(tmpPath[i] + "\\");
                }
                CurrentPath = sb.ToString();
            }
            else CurrentPath = clickName;

            UpdateList();
        }

        private void UpdateList()
        {
            fileSystem.Items.Clear();

            CurrentIndex = -1;

            string[] dirs = Directory.GetDirectories(CurrentPath);
            string[] files = Directory.GetFiles(CurrentPath);

            fileSystem.Items.Add("[...]");
            foreach (string dir in dirs) fileSystem.Items.Add(dir);
            foreach (string file in files) fileSystem.Items.Add(file);
        }
    }
}
