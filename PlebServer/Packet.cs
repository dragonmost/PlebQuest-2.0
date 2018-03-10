using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebServer
{
    public class Packet
    {
        public string CommandName { get; set; }
        public object[] Parameters { get; set; }
    }
}
