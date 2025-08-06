namespace Constractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ✅ Step 4: Create instances of the Constractor class
            Constractor employee1 = new Constractor(1, "Alice", "1234567890", "alice404@gmail.com ","123 Main St, City", 50000);
            Constractor employee2 = new Constractor(2, "Bob", "0987654321", "bob534@gmail.com ", "456 Elm St, City", 60000);
            Constractor employee3 = new Constractor(3, "Charlie", "1122334455", "charlie145@gmai.com ", "789 Oak St, City", 55000);

            Console.WriteLine("Employee Details:");
            // ✅ Step 5: Display details of each employee
            employee1.DisplayDetails();
            employee2.DisplayDetails();
            employee3.DisplayDetails();
            // ✅ Step 6: Wait for user input before closing the console
            Console.WriteLine("Press any key to exit...");

            Console.ReadLine();
        }
    }
}
