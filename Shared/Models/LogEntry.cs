using System;
using System.Collections.Generic;
using System.Text;

namespace cstranslator.Shared.Models
{
    public class LogEntry
    {
        public string Type { get; set; }
        public string Text { get; set; }

        public LogEntry (string type, string text)
        {
            this.Type = type;
            this.Text = text;
        }
    }
}