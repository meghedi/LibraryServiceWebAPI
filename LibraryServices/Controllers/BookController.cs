using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LibraryServices.Data.Interfaces;
using LibraryServices.Data.Models;
using LibraryServices.Data.Repositories;

namespace LibraryServices.Controllers
{
    public class BookController : ApiController
    {
       //  private IBookRepository books= new BookRepository(); 

        private readonly IBookRepository _books;

        public BookController(IBookRepository books)
        {
            _books = books;
        }
      
        // GET api/book
        public IEnumerable<Book> Get()
        {
            return _books.GetAllBooks();
        }

        // GET api/book/5
        public IHttpActionResult Get(int id)
        {
            var book = _books.GetBook(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }
    }
}
