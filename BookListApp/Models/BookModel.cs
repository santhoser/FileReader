namespace BookListApp.Models
{
    public class BookModel
    {
        public BookModel() { }
        public BookModel(string name, string isbn, string author)
        {
            this.Name = name;
            this.ISBN = isbn;
            this.Author = author;
        }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
    }
}