using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book? LinearSearch(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return book;
            }
            return null;
        }

        public Book? BinarySearch(string title)
        {
            books.Sort((a, b) => a.Title.CompareTo(b.Title)); // Sort before binary search
            int low = 0, high = books.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int compare = string.Compare(books[mid].Title, title, StringComparison.OrdinalIgnoreCase);

                if (compare == 0)
                    return books[mid];
                else if (compare < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return null;
        }

        public void DisplayAll()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
