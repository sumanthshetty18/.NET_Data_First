using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCapp1.Models
{
    public partial class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the Trainee Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Ename { get; set; }

        [Required(ErrorMessage = "Enter the Trainee Designation")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Designation { get; set; }
    }
}
