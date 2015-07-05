namespace Notes
{
    partial class LogEntryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timestamp = new System.Windows.Forms.Label();
            this.entry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timestamp
            // 
            this.timestamp.AutoSize = true;
            this.timestamp.Location = new System.Drawing.Point(4, 4);
            this.timestamp.Name = "timestamp";
            this.timestamp.Size = new System.Drawing.Size(49, 13);
            this.timestamp.TabIndex = 0;
            this.timestamp.Text = "00:00:00";
            this.timestamp.Click += new System.EventHandler(this.timestamp_Click);
            // 
            // entry
            // 
            this.entry.AutoSize = true;
            this.entry.Location = new System.Drawing.Point(74, 4);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(30, 13);
            this.entry.TabIndex = 1;
            this.entry.Text = "entry";
            this.entry.Click += new System.EventHandler(this.entry_Click);
            // 
            // LogEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entry);
            this.Controls.Add(this.timestamp);
            this.Name = "LogEntry";
            this.Size = new System.Drawing.Size(710, 22);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogEntry_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timestamp;
        private System.Windows.Forms.Label entry;
    }
}
