namespace EmployeeManagement
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(string id, string name, string position, double salary)
        {
            EmployeeId = id;
            Name = name;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{EmployeeId} | {Name} | {Position} | ₹{Salary}";
        }
    }
}
