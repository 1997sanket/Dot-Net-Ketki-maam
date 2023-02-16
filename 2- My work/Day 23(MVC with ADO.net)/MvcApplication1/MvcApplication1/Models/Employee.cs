using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Employee
    {
        [Display(Name = "Employee Id")]
        public int Id { get; set; }

        [Display(Name = "Name")] [Required(ErrorMessage = "Name is required")]
        public String Name { get; set; }

        [Display(Name = "Salary")] [Required(ErrorMessage = "Salary required")]
        public float Salary { get; set; }
    }
}