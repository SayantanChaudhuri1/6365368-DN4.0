namespace LibraryManagement
{
    public class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string id, string title, string author)
        {
            BookId = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{BookId} | {Title} | {Author}";
        }
    }
}
