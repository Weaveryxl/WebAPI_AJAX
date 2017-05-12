using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI_AJAX.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentID { get; set; }
        public DateTime JoinDate { get; set; }

        [ForeignKey("ID")]
        public Department Department { get; set; }
    }
}