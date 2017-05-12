using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI_AJAX.Models;


namespace WebAPI_AJAX.Controllers
{
   
    public class EmployeesController : ApiController
    {
        Employee[] Employees = new Employee[]
        {
            new Employee {EmployeeID=111,Name="aaa", Salary=10000, DepartmentID= 1, JoinDate=
                DateTime.Parse("5/1/2008 8:30:52 AM",
                          System.Globalization.CultureInfo.InvariantCulture) }
        };

        public IList<Employee> GetAllEmployees() // here I try to use IList, not IEnumrable
        {
            return Employees;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = Employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public string Save(Employee emp)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(emp);
            return json; 
        }
    }
}
