﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [StringLength(50, MinimumLength = 1, ErrorMessage = "50 character limit")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [StringLength(50, MinimumLength = 1, ErrorMessage = "50 character limit")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get { return LastName + ", " + FirstName; } }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}