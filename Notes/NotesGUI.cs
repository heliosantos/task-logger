using MovablePython;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Notes
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.ShowInTaskbar = false;

            Rectangle screenSize = Screen.FromControl(this).Bounds;
            this.Location = new Point(0, 0);
            this.Size = new Size(screenSize.Width, screenSize.Height / 2);

            ReadFromFile();


            Hotkey hk = new Hotkey();

            hk.KeyCode = Keys.A;

            hk.Alt = true;
            hk.Pressed += delegate { this.Visible = !this.Visible; };

            hk.Register(this); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void AddEntry()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }

            AddEntry(new LogEntry() { Entry = textBox1.Text, Timestamp = DateTime.Now});
            textBox1.Text = "";
        }

        private void AddEntry(LogEntry logEntry)
        {
            LogEntryControl logEntryControl = new LogEntryControl(logEntry);

            this.entriesPanel.Controls.Add(logEntryControl);
            //this.entriesPanel.Controls.SetChildIndex(logEntry, 0);

            //logEntry.Location = new System.Drawing.Point(3, 186);
            //logEntry.Name = "logEntry1";
            logEntryControl.Size = new System.Drawing.Size(this.entriesPanel.Width - 30, 22);
            //logEntry.TabIndex = 0;

        }

        private void entriesPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            this.entriesPanel.VerticalScroll.Value = this.entriesPanel.VerticalScroll.Maximum;
            SaveToFile();
        }

        private void SaveToFile()
        {
            List<LogEntry> entries = new List<LogEntry>();

            foreach (var c in entriesPanel.Controls)
            {
                LogEntryControl entry = c as LogEntryControl;
                entries.Add(entry.LogEntry);
            }

            var xs = new XmlSerializer(entries.GetType());
            var xml = new StringWriter();
            xs.Serialize(xml, entries);
            
            
            File.WriteAllText("entries.xml", xml.ToString());
        }

        private void ReadFromFile()
        {
            if (File.Exists("entries.xml"))
            {
                string xmlString = File.ReadAllText("entries.xml");
                List<LogEntry> entries = new List<LogEntry>();

                using (StreamReader fs = File.OpenText("entries.xml"))
                {
                    var xs = new XmlSerializer(entries.GetType());
                    entries = (List<LogEntry>)xs.Deserialize(fs);
                }

                foreach (LogEntry l in entries)
                {
                    AddEntry(l);
                }
            }
        }
    }
}
