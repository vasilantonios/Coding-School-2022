using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {   Guid InstId { get; set; } = Guid.NewGuid();

        public string InstName {get; set; }
        public string GetName() { return InstName; }
        //public void SetName(string name) { Name = name; }
        public int YearsServ { get; set; }


    }
}
