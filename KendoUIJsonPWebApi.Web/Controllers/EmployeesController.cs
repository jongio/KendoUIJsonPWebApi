using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KendoUIJsonPWebApi.Web.Models;

namespace KendoUIJsonPWebApi.Web.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly List<Employee> _employees = new List<Employee> 
        {
            new Employee{ FullName = "Jon Gallant", EmployeeId = 1, HasEmployees = true, ReportsTo = null},
            new Employee{ FullName = "Scott Hanselman", EmployeeId = 2, HasEmployees = false, ReportsTo = 1},
            new Employee {FullName = "Howard Dierking", EmployeeId = 3, HasEmployees = false, ReportsTo = 1},
            new Employee {FullName = "Drew Miller", EmployeeId = 4, HasEmployees = false, ReportsTo = 1},
            new Employee { FullName = "Jeff Atwood", EmployeeId = 5, HasEmployees = false, ReportsTo = 1}
        };

        public IEnumerable<Employee> Get()
        {
            return _employees.Where(e => !e.ReportsTo.HasValue);
        }

        public IEnumerable<Employee> Get(int employeeId)
        {
            return _employees.Where(e => e.ReportsTo == employeeId);
        }
    }
}
