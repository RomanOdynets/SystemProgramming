namespace PW_03_04
{
    partial class mainForm
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
            this.filePath_tb = new System.Windows.Forms.TextBox();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.result_lbl = new System.Windows.Forms.Label();
            this.searchWord_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filePath_tb
            // 
            this.filePath_tb.Enabled = false;
            this.filePath_tb.Location = new System.Drawing.Point(13, 39);
            this.filePath_tb.Name = "filePath_tb";
            this.filePath_tb.Size = new System.Drawing.Size(469, 20);
            this.filePath_tb.TabIndex = 0;
            // 
            // openFile_btn
            // 
            this.openFile_btn.Location = new System.Drawing.Point(488, 36);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(75, 23);
            this.openFile_btn.TabIndex = 1;
            this.openFile_btn.Text = "Open";
            this.openFile_btn.UseVisualStyleBackColor = true;
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(570, 35);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Location = new System.Drawing.Point(13, 94);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(0, 13);
            this.result_lbl.TabIndex = 3;
            // 
            // searchWord_tb
            // 
            this.searchWord_tb.Location = new System.Drawing.Point(13, 13);
            this.searchWord_tb.Name = "searchWord_tb";
            this.searchWord_tb.Size = new System.Drawing.Size(469, 20);
            this.searchWord_tb.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 119);
            this.Controls.Add(this.searchWord_tb);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.openFile_btn);
            this.Controls.Add(this.filePath_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath_tb;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.TextBox searchWord_tb;
    }
}

