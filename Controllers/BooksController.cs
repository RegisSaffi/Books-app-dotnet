using Books_218011357.Models;
using Books_218011357.Services;
using Microsoft.AspNetCore.Mvc;

namespace Books_218011357.Controllers
{
    public class BooksController : Controller
    {
        
        public IActionResult ListBooks()
        {
            var books = new BookViewModel();
            books.Books= new BookRepository().GetAllBooks();
            
            return View(books);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                
            }
          
            return View();
        }
    }
}