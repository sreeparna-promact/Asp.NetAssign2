using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard22.Models
{
    public class MessageData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string messageBody { get; set; }
        public string date { get; set; }
        public string comment { get; set; }
        public string commenter { get; set; }
        public string like { get; set; }
    }
}
