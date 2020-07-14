namespace FileSystemManager.UI
{
    partial class Main
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
            this.driverVolume_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // driverVolume_cb
            // 
            this.driverVolume_cb.FormattingEnabled = true;
            this.driverVolume_cb.Location = new System.Drawing.Point(667, 37);
            this.driverVolume_cb.Name = "driverVolume_cb";
            this.driverVolume_cb.Size = new System.Drawing.Size(121, 21);
            this.driverVolume_cb.TabIndex = 0;
            this.driverVolume_cb.SelectedIndexChanged += new System.EventHandler(this.driverVolume_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select driver:";
            // 
            // fileSystem
            // 
            this.fileSystem.FormattingEnabled = true;
            this.fileSystem.Location = new System.Drawing.Point(13, 13);
            this.fileSystem.Name = "fileSystem";
            this.fileSystem.Size = new System.Drawing.Size(639, 420);
            this.fileSystem.TabIndex = 2;
            this.fileSystem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileSystem_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileSystem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driverVolume_cb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox driverVolume_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fileSystem;
    }
}