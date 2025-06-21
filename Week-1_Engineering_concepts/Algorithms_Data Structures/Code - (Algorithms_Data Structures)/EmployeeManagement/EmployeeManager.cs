using System;

namespace EmployeeManagement
{
    public class EmployeeManager
    {
        private Employee[] employees;
        private int count;

        public EmployeeManager(int size)
        {
            employees = new Employee[size];
            count = 0;
        }

        public void AddEmployee(Employee emp)
        {
            if (count >= employees.Length)
            {
                Console.WriteLine("Array is full. Cannot add more employees.");
                return;
            }
            employees[count++] = emp;
            Console.WriteLine("Employee added.");
        }

        public Employee SearchEmployee(string id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == id)
                    return employees[i];
            }
            return null;
        }

        public void DisplayEmployees()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        public void DeleteEmployee(string id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    employees[--count] = null;
                    Console.WriteLine(" Employee deleted.");
                    return;
                }
            }
            Console.WriteLine(" Employee not found.");
        }
    }
}
