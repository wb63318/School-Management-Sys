using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementsys_api.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string courseName { get; set; }

        public string? courseDescription { get; set; }

        public StudentCourses studentCourses { get; set; }
    }
}
