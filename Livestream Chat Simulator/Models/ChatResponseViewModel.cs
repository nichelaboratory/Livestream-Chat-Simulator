using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livestream_Chat_Simulator.Models
{
    public class ChatResponseViewModel
    {
        public string UserName { get; set; }
        public string Response { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
