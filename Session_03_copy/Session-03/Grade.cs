using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid RegistrationNumber { get; }

        public Guid CourceId { get; set;}
        
        public int grade { get; set; }

        public Grade()
            {  }
    }
}
