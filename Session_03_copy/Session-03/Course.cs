﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {
        public Guid CourseId { get; } = Guid.NewGuid();
        public string Code { get; set; }
        public string Subject { get; set; }

    }
}
