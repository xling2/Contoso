using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Model.Models
{
    [Table("Instructor")]
    public class Instructor : People
    {
        [Required]
        public DateTime HireDate { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
