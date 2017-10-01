using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Required")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}