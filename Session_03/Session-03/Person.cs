using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        public string Name { get; set; }
        public Guid PersonId { get; } = Guid.NewGuid();

        //public DateTime DoB { get; set; }

        public int Age { get; set; }

        public string GetName() { return Name; }
        public void SetName(string name) { Name = name; }

        public Person()
        {
        }

    }


}
