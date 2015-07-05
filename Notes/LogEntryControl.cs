using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Notes
{
    public partial class LogEntryControl : UserControl
    {
        public LogEntry LogEntry { get; set; }
        public LogEntryControl(LogEntry logEntry)
        {
            InitializeComponent();

            this.LogEntry = logEntry;
            this.timestamp.Text = logEntry.Timestamp.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            this.entry.Text = logEntry.Entry;

        }

        bool Selected = false;

        private void ToogleSelection()
        {
            Selected = !Selected;

            if (Selected)
            {
                timestamp.ForeColor = Color.AliceBlue;
                entry.ForeColor = Color.AliceBlue;
            }
            else
            {
                timestamp.ForeColor = Color.Black;
                entry.ForeColor = Color.Black;
            }
        }

        private void LogEntry_MouseClick(object sender, MouseEventArgs e)
        {
            ToogleSelection();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            ToogleSelection();
        }

        private void timestamp_Click(object sender, EventArgs e)
        {
            ToogleSelection();
        }
    }
}
