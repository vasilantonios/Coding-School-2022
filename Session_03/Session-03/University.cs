using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University
    {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; } 
        public Schedule[] Schedules { get; set; }
        public University()
        {
            Students = new Student[20];
            Courses = new Course[5];
            Schedules = new Schedule[60];
        }
        public Student[] GetStudents() { return Students; }
        public Course[] GetCourses() { return Courses; }
        
        public Grade[] GetGrades() { return Grades; }
        public void SetSchedule(Guid CourseId, Guid ProfId, DateTime datetime)
        {

        }

    }
}
