using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.books
{
    class BookService
    {

        private LibraryEntities context;

        public BookService()
        {
            context = new LibraryEntities();
        }

        public List<Book> loadBooks()
        {
            return context.Book.ToList();
        }

        public Book getBookById(int id)
        {
            return context.Book.Find(id);
        }
    }
}
