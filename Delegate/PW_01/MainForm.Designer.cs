namespace PW_01
{
    partial class MainForm
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
            this.proccess_dg = new System.Windows.Forms.DataGridView();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.current_time_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.info3 = new System.Windows.Forms.Label();
            this.info4 = new System.Windows.Forms.Label();
            this.info5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proccess_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // proccess_dg
            // 
            this.proccess_dg.AllowUserToAddRows = false;
            this.proccess_dg.AllowUserToDeleteRows = false;
            this.proccess_dg.AllowUserToResizeColumns = false;
            this.proccess_dg.AllowUserToResizeRows = false;
            this.proccess_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.proccess_dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.proccess_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proccess_dg.Location = new System.Drawing.Point(13, 13);
            this.proccess_dg.Name = "proccess_dg";
            this.proccess_dg.ReadOnly = true;
            this.proccess_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proccess_dg.Size = new System.Drawing.Size(687, 425);
            this.proccess_dg.TabIndex = 0;
            this.proccess_dg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.proccess_dg_CellMouseClick);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(707, 63);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(34, 23);
            this.up.TabIndex = 1;
            this.up.Text = "+";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(754, 63);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(34, 23);
            this.down.TabIndex = 2;
            this.down.Text = "-";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // current_time_tb
            // 
            this.current_time_tb.Enabled = false;
            this.current_time_tb.Location = new System.Drawing.Point(707, 37);
            this.current_time_tb.Name = "current_time_tb";
            this.current_time_tb.Size = new System.Drawing.Size(81, 20);
            this.current_time_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current update";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(707, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Hide system";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(704, 194);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(0, 13);
            this.info1.TabIndex = 6;
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Location = new System.Drawing.Point(704, 219);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(0, 13);
            this.info2.TabIndex = 7;
            // 
            // info3
            // 
            this.info3.AutoSize = true;
            this.info3.Location = new System.Drawing.Point(704, 246);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(0, 13);
            this.info3.TabIndex = 8;
            // 
            // info4
            // 
            this.info4.AutoSize = true;
            this.info4.Location = new System.Drawing.Point(704, 271);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(0, 13);
            this.info4.TabIndex = 9;
            // 
            // info5
            // 
            this.info5.AutoSize = true;
            this.info5.Location = new System.Drawing.Point(704, 295);
            this.info5.Name = "info5";
            this.info5.Size = new System.Drawing.Size(0, 13);
            this.info5.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info5);
            this.Controls.Add(this.info4);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.current_time_tb);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.proccess_dg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.proccess_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proccess_dg;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.TextBox current_time_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label info3;
        private System.Windows.Forms.Label info4;
        private System.Windows.Forms.Label info5;
    }
}

