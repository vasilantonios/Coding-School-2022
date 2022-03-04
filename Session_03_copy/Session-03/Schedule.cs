using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Schedule
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid CourseId { get; }

        public Guid ProfId { get; }
        public string Subject { get; set; }

        public DateTime DateTime { get; set; }

    }
}
