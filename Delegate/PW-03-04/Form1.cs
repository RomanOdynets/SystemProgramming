using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_03_04
{
    public partial class mainForm : Form
    {
        private string aimWord;
        private Thread thread;
        private int wordCount = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt";
            DialogResult res = openFile.ShowDialog();
            if(res == DialogResult.OK) filePath_tb.Text = openFile.FileName;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            wordCount = 0;
            aimWord = searchWord_tb.Text;
            if (!File.Exists(filePath_tb.Text)) return;
            Task.Run(() => Searcher());

        }

        private async Task Searcher()
        {
            try
            {
                using(StreamReader sr = new StreamReader(filePath_tb.Text, Encoding.Default))
                {
                    string line;
                    while((line = await sr.ReadLineAsync()) != null)
                    {
                        string[] buffer;
                        buffer = line.Split(' ');
                        foreach (string word in buffer) wordCount = word.Contains(aimWord) ? wordCount + 1 : wordCount;
                    }
                }
                result_lbl.Text = "Find: " + wordCount + " words";
            }
            catch { }
        }
    }
}
