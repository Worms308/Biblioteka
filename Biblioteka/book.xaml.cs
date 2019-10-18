using Biblioteka.books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy book.xaml
    /// </summary>
    public partial class book : Page
    {
        private BookService bookService;

        public book()
        {
            InitializeComponent();
            this.bookService = new BookService();
            this.loadBooks();
        }

        public void loadBooks()
        {
            List<Book> books = bookService.loadBooks();
            List<BookDTO> bookDTOs = new List<BookDTO>();

            foreach(Book it in books)
            {
                bookDTOs.Add(BookTransformer.createDto(it));
            }

            bookTable.ItemsSource = bookDTOs;
        }

        private void AddBookButton(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.ShowDialog();
            this.loadBooks();
        }

        private void RemoveBookButton(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeBookButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
