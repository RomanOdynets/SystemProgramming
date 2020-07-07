namespace ThreadTest
{
    partial class ProcessInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.info3 = new System.Windows.Forms.Label();
            this.info4 = new System.Windows.Forms.Label();
            this.info5 = new System.Windows.Forms.Label();
            this.info6 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(13, 13);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(13, 13);
            this.info1.TabIndex = 0;
            this.info1.Text = "1";
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Location = new System.Drawing.Point(13, 26);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(13, 13);
            this.info2.TabIndex = 1;
            this.info2.Text = "1";
            // 
            // info3
            // 
            this.info3.AutoSize = true;
            this.info3.Location = new System.Drawing.Point(13, 39);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(13, 13);
            this.info3.TabIndex = 2;
            this.info3.Text = "1";
            // 
            // info4
            // 
            this.info4.AutoSize = true;
            this.info4.Location = new System.Drawing.Point(13, 52);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(13, 13);
            this.info4.TabIndex = 3;
            this.info4.Text = "1";
            // 
            // info5
            // 
            this.info5.AutoSize = true;
            this.info5.Location = new System.Drawing.Point(13, 65);
            this.info5.Name = "info5";
            this.info5.Size = new System.Drawing.Size(13, 13);
            this.info5.TabIndex = 4;
            this.info5.Text = "1";
            // 
            // info6
            // 
            this.info6.AutoSize = true;
            this.info6.Location = new System.Drawing.Point(13, 78);
            this.info6.Name = "info6";
            this.info6.Size = new System.Drawing.Size(13, 13);
            this.info6.TabIndex = 5;
            this.info6.Text = "1";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(16, 123);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 6;
            this.close.Text = "Kill";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProcessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.info6);
            this.Controls.Add(this.info5);
            this.Controls.Add(this.info4);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProcessInfo";
            this.Text = "ProcessInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label info3;
        private System.Windows.Forms.Label info4;
        private System.Windows.Forms.Label info5;
        private System.Windows.Forms.Label info6;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
    }
}