using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Books_218011357.Models;

namespace Books_218011357.Services
{
    public class BookRepository:IBookRepository
    {
        public void CreateBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            IEnumerable<Book> books = new List<Book>()
            {
                new Book() {ISBN = "35563g36536", Title = "The moment of lift"},
                new Book() {ISBN = "gdhd5e788ehb", Title = "Introduction to Dotnet core framework"},
                new Book() {ISBN = "hdc79d0d9dbd", Title = "Python programming for beginners"},
                new Book() {ISBN = "dhhd7dd89ddb", Title = "Javascript in action"},
                new Book() {ISBN = "443b3h334334", Title = "React fundamentals"}
            };
            
            return books;
        }
    }

    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}