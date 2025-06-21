using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager(5);

            manager.AddEmployee(new Employee("E001", "Alice", "Manager", 60000));
            manager.AddEmployee(new Employee("E002", "Bob", "Developer", 50000));
            manager.AddEmployee(new Employee("E003", "Charlie", "Designer", 45000));

            Console.WriteLine("\n All Employees:");
            manager.DisplayEmployees();

            Console.WriteLine("\n Search for E002:");
            var found = manager.SearchEmployee("E002");
            Console.WriteLine(found != null ? found.ToString() : "Not found");

            Console.WriteLine("\n Deleting E002...");
            manager.DeleteEmployee("E002");

            Console.WriteLine("\n After Deletion:");
            manager.DisplayEmployees();

            Console.ReadLine();
        }
    }
}
