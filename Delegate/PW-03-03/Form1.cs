using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace PW_03_03
{
    public partial class Form1 : Form
    {
        private int finalNum = 0;
        private Thread th;
        private Dispatcher dispatcher = Dispatcher.CurrentDispatcher;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(textBox1.Text, out finalNum);
            if (!result) return;

            if(finalNum == 0 || finalNum == 1)
            {
                ans.Items.Add(finalNum);
                return;
            }

            th = new Thread(new ThreadStart(Counting));
            th.Start();
        }

        private void Counting()
        {
            List<int> res = new List<int>();
            int current = 2;
            int temp = 1;
            do
            {
                current = current + temp; // 2 + 1
                temp = current - temp; // 3 - 1
                res.Add(current);
                dispatcher.Invoke(
                    new Action(() =>
                    {
                        ans.Items.Add(current);
                    }));
            }
            while (res[res.Count-1] < finalNum);
            dispatcher.Invoke(
                    new Action(() =>
                    {
                        ans.Items.RemoveAt(ans.Items.Count - 1);
                    }));
        }

        private int Fibonachi(int x)
        {
            if (x == 0) return 0;
            else if (x == 1) return 1;
            else return Fibonachi(x - 1) + Fibonachi(x - 2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            th.Abort();
        }
    }
}
