using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    internal class Constractor
    {
        // ✅ Step 1: Create object
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAddress { get; set; }
        public decimal Salary { get; set; }
        // ✅ Step 2: Constructor to initialize properties
        public Constractor(int id, string name, string phone, string email, string address, decimal salary)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeePhone = phone;
            EmployeeEmail = email;
            EmployeeAddress = address;
            Salary = salary;
        }
        // ✅ Step 3: Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Name: {EmployeeName}");
            Console.WriteLine($"Phone: {EmployeePhone}");
            Console.WriteLine($"Email: {EmployeeEmail}");
            Console.WriteLine($"Address: {EmployeeAddress}");
            Console.WriteLine($"Salary: {Salary} Tk");
            Console.WriteLine(" ");
        }
    }
}
