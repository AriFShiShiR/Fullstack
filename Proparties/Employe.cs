using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proparties
{
    internal class Employe
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }

        // Keep as string — because phone numbers can start with 0 and have special characters
        public string? EmployeePhone { get; set; }

        public string? EmployeeEmail { get; set; }
        public string? EmployeeAddress { get; set; }

        // Change to decimal for precise financial calculation
        public decimal Salary { get; set; }
    }
}

