using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    { public string Rank { get; set; }
        public Guid ProfId { get; } = Guid.NewGuid();

        public void SetGrade(Guid RegistrationNumber, Guid CourceId, int Grade)
        {
        }

    public void CourcesTeach(Course course, DateTime date) 
    {
    }

    }
}
