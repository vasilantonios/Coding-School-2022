using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5
{
    internal class Message
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Message()
        {
            Id = Guid.NewGuid();
        }
    }
}
