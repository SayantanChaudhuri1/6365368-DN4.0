using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("B001", "C# Fundamentals", "Alice"));
            library.AddBook(new Book("B002", "Java Programming", "Bob"));
            library.AddBook(new Book("B003", "Python Basics", "Charlie"));
            library.AddBook(new Book("B004", "Web Development", "David"));

            Console.WriteLine("\n All Books:");
            library.DisplayAll();

            Console.WriteLine("\n Linear Search for 'Python Basics':");
            var linear = library.LinearSearch("Python Basics");
            Console.WriteLine(linear != null ? linear.ToString() : "Not found");

            Console.WriteLine("\n Binary Search for 'Python Basics':");
            var binary = library.BinarySearch("Python Basics");
            Console.WriteLine(binary != null ? binary.ToString() : "Not found");

            Console.ReadLine();
        }
    }
}
