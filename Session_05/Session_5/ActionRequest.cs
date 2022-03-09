using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5
{
    public enum ActionEnum
    {
        Conv,
        Upcase,
        Rev
    }
    internal class ActionRequest
    {
        public Guid RequestId { get; set; }
        public string Input { get; set; }

        public ActionEnum Action { get; set; }


    }



}

