using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5
{
    internal class ActionResolver
    {
        public MessageLogger MesLog { get; set; }
        public ActionResolver(MessageLogger meslog)
        {
            MesLog = meslog;
        }
    public ActionResponce Execute(ActionRequest recquest)
        {
            var responce = new ActionResponce();
        }


    }


}
