using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int EmployeeSsn { get; set; }
        public string EmployeeFName { get; set; }
        public string EmployeeMinit {  get; set; }
        public string EmployeeLName { get; set; }
        public string EmployeeBdate { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeSex { get; set; }
        public double EmployeeSalary { get; set; }

    }
}
