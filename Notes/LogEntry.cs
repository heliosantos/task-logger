using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    [Serializable()]
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Entry { get; set; }

    }
}
