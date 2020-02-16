using System.Collections.Generic;
using System.Linq;
using Books_218011357.Models;

namespace Books_218011357.Services
{
    public interface IBookRepository
    {
        void CreateBook(Book book);
        IEnumerable<Book> GetAllBooks();
    }
}