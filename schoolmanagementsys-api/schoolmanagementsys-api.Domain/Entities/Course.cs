using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace schoolmanagementsys_api.Domain.Entities
{
    public class Course
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None), Display(Name = "CourseCode"), Range(058, 101)]

        public int Id { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 5), Display(Name = "Credit Hours")]
        public int Credits { get; set; }

        public StudentCourses studentCourses { get; set; }
    }
}
