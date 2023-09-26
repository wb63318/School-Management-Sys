using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementsys_api.Domain.Entities
{
    public class StudentCourses
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }


        public List<Course> Courses { get; set; }

    }
}
