using System;

namespace TaskManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();

            manager.AddTask(new Task("T001", "Design DB", "Pending"));
            manager.AddTask(new Task("T002", "Code API", "In Progress"));
            manager.AddTask(new Task("T003", "Test Module", "Pending"));

            Console.WriteLine("\n📋 All Tasks:");
            manager.DisplayTasks();

            Console.WriteLine("\n🔍 Searching for T002:");
            var task = manager.SearchTask("T002");
            Console.WriteLine(task != null ? task.ToString() : "Task not found");

            Console.WriteLine("\n🗑️ Deleting T002...");
            manager.DeleteTask("T002");

            Console.WriteLine("\n📋 After Deletion:");
            manager.DisplayTasks();

            Console.ReadLine();
        }
    }
}
