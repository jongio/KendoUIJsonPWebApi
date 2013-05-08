using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIJsonPWebApi.Web.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public bool HasEmployees { get; set; }
        public int? ReportsTo { get; set; }
    }
}