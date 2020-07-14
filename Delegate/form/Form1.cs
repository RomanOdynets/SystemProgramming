using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{

    public partial class Form1 : Form
    {
        private ProgressBar[] bars;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count;
            bool res = int.TryParse(textBox1.Text, out count);
            if (!res) return;
            bars = new ProgressBar[count];

            for (int i = 0; i < count; i++)
            {
                bars[i] = new ProgressBar();
                bars[i].Location = new Point(10, 10 * (i+1)*2);
                bars[i].Size = new Size(100, 20);
                this.Controls.Add(bars[i]);
            }
        }
    }
}
