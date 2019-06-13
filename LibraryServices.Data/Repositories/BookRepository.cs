using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Data.Interfaces;
using LibraryServices.Data.Models;

namespace LibraryServices.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> Books = new List<Book>()
        {
            new Book{Id=1, Title="little girls", Author = "Paula", PublicationYear = 2015, CallNumber = "F Hanki"},
            new Book{Id=2, Title="little girls 2", Author = "John", PublicationYear = 2016, CallNumber = "B Hanki"},
            new Book{Id=3, Title="little girls 3", Author = "Meg", PublicationYear = 2011, CallNumber = "N Hanki"},
            new Book{Id=4, Title="little girls 4", Author = "Moyo", PublicationYear = 2012, CallNumber = "M Hanki"},
            new Book{Id=5, Title="little girls 5", Author = "Jojo", PublicationYear = 2010, CallNumber = "S Hanki"},
        };

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBook(int id)
        {
            var book = Books.FirstOrDefault(x => x.Id == id);
            return book;

        }
    }
}
