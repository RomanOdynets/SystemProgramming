namespace PW_01_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.paintStart_btn = new System.Windows.Forms.Button();
            this.calcStart_btn = new System.Windows.Forms.Button();
            this.notepadStart_Btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.processPath_tb = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.status_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paintStart_btn
            // 
            this.paintStart_btn.Location = new System.Drawing.Point(40, 39);
            this.paintStart_btn.Name = "paintStart_btn";
            this.paintStart_btn.Size = new System.Drawing.Size(75, 23);
            this.paintStart_btn.TabIndex = 0;
            this.paintStart_btn.Text = "Start Paint";
            this.paintStart_btn.UseVisualStyleBackColor = true;
            this.paintStart_btn.Click += new System.EventHandler(this.paintStart_btn_Click);
            // 
            // calcStart_btn
            // 
            this.calcStart_btn.Location = new System.Drawing.Point(121, 39);
            this.calcStart_btn.Name = "calcStart_btn";
            this.calcStart_btn.Size = new System.Drawing.Size(75, 23);
            this.calcStart_btn.TabIndex = 1;
            this.calcStart_btn.Text = "Start Calc";
            this.calcStart_btn.UseVisualStyleBackColor = true;
            this.calcStart_btn.Click += new System.EventHandler(this.calcStart_btn_Click);
            // 
            // notepadStart_Btn
            // 
            this.notepadStart_Btn.Location = new System.Drawing.Point(202, 39);
            this.notepadStart_Btn.Name = "notepadStart_Btn";
            this.notepadStart_Btn.Size = new System.Drawing.Size(85, 23);
            this.notepadStart_Btn.TabIndex = 2;
            this.notepadStart_Btn.Text = "Start Notepad";
            this.notepadStart_Btn.UseVisualStyleBackColor = true;
            this.notepadStart_Btn.Click += new System.EventHandler(this.notepadStart_Btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(278, 88);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 23);
            this.open_btn.TabIndex = 3;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // processPath_tb
            // 
            this.processPath_tb.Enabled = false;
            this.processPath_tb.Location = new System.Drawing.Point(40, 90);
            this.processPath_tb.Name = "processPath_tb";
            this.processPath_tb.Size = new System.Drawing.Size(232, 20);
            this.processPath_tb.TabIndex = 4;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(359, 87);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(40, 117);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 13);
            this.status_lbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 140);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.processPath_tb);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.notepadStart_Btn);
            this.Controls.Add(this.calcStart_btn);
            this.Controls.Add(this.paintStart_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paintStart_btn;
        private System.Windows.Forms.Button calcStart_btn;
        private System.Windows.Forms.Button notepadStart_Btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.TextBox processPath_tb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label status_lbl;
    }
}

