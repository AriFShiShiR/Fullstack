using System;
namespace Proparties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// ✅ Step 1: Create object
            Employe emp = new Employe();

            // ✅ Step 2: Set values (hardcoded or from user input)
            Console.Write("Enter Employee ID: ");
            emp.EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.EmployeeName = Console.ReadLine();

            Console.Write("Enter Phone: ");
            emp.EmployeePhone = Console.ReadLine();

            Console.Write("Enter Email: ");
            emp.EmployeeEmail = Console.ReadLine();

            Console.Write("Enter Address: ");
            emp.EmployeeAddress = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = Convert.ToDecimal(Console.ReadLine());

            

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"ID: {emp.EmployeeId}");
            Console.WriteLine($"Name: {emp.EmployeeName}");
            Console.WriteLine($"Phone: {emp.EmployeePhone}");
            Console.WriteLine($"Email: {emp.EmployeeEmail}");
            Console.WriteLine($"Address: {emp.EmployeeAddress}");
            Console.WriteLine($"Salary: {emp.Salary} Tk");
            Console.WriteLine(" ");

            // ✅ Step 2: Set values (hardcoded or from user input)
            emp.EmployeeId = 1002;
            emp.EmployeeName = "Shishir";
            emp.EmployeePhone = "0188210365";
            emp.EmployeeEmail = "arifshishir20203030@gmail.com";
            emp.EmployeeAddress = "Uttara, Dhaka";
            emp.Salary = 35000.75m;

            // ✅ Step 3: Get/Print values
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"ID: {emp.EmployeeId}");
            Console.WriteLine($"Name: {emp.EmployeeName}");
            Console.WriteLine($"Phone: {emp.EmployeePhone}");
            Console.WriteLine($"Email: {emp.EmployeeEmail}");
            Console.WriteLine($"Address: {emp.EmployeeAddress}");
            Console.WriteLine($"Salary: {emp.Salary} Tk");
            Console.ReadLine();*/

            // ✅ List to hold all employees
            List<Employe> employees = new List<Employe>();

            // ✅ Step 1: Add default employee
            Employe defaultEmp = new Employe
            {
                EmployeeId = 1002,
                EmployeeName = "Shishir",
                EmployeePhone = "0188210365",
                EmployeeEmail = "arifshishir20203030@gmail.com",
                EmployeeAddress = "Uttara, Dhaka",
                Salary = 35000.75m
            };

            employees.Add(defaultEmp);

            // ✅ Step 2: Take new employee input from user
            Employe newEmp = new Employe();

            // ✅ Loop to ensure unique ID
            int inputId;
            while (true)
            {
                Console.Write("Enter Employee ID: ");
                inputId = Convert.ToInt32(Console.ReadLine());

                if (employees.Exists(e => e.EmployeeId == inputId))
                {
                    Console.WriteLine("⚠️ ID already exists! Please try a different one.\n");
                }
                else
                {
                    break; // ID is unique
                }
            }

            newEmp.EmployeeId = inputId;

            Console.Write("Enter Employee Name: ");
            newEmp.EmployeeName = Console.ReadLine();

            Console.Write("Enter Phone: ");
            newEmp.EmployeePhone = Console.ReadLine();

            Console.Write("Enter Email: ");
            newEmp.EmployeeEmail = Console.ReadLine();

            Console.Write("Enter Address: ");
            newEmp.EmployeeAddress = Console.ReadLine();

            Console.Write("Enter Salary: ");
            newEmp.Salary = Convert.ToDecimal(Console.ReadLine());

            employees.Add(newEmp); // Add the new employee to the list

            // ✅ Step 3: Show all employees
            Console.WriteLine("\n--- All Employees ---");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.EmployeeId}");
                Console.WriteLine($"Name: {emp.EmployeeName}");
                Console.WriteLine($"Phone: {emp.EmployeePhone}");
                Console.WriteLine($"Email: {emp.EmployeeEmail}");
                Console.WriteLine($"Address: {emp.EmployeeAddress}");
                Console.WriteLine($"Salary: {emp.Salary} Tk");
                Console.WriteLine();
            }

            Console.ReadLine(); // Keep console open

        }
    }
}
