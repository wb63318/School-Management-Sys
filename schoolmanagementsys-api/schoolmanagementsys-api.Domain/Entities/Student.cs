using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace schoolmanagementsys_api.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Last Name"), StringLength(50, MinimumLength = 3, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string LastName { get; set; }

        [Display(Name = "First Name"), StringLength(50, MinimumLength = 3, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        public string FullName { get { return LastName + " " + FirstName; } }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DoB { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
