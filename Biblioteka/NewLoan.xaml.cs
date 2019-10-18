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
using System.Windows.Shapes;
using Biblioteka.users;
using Biblioteka.books;
using Biblioteka.admins;
using Biblioteka.loans;

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy NewLoan.xaml
    /// </summary>
    public partial class NewLoan : Window
    {
        private UserService userService;
        private BookService bookService;
        private LoanService loanService;
        private LibraryEntities context = new LibraryEntities();

        public NewLoan()
        {
            InitializeComponent();

            userService = new UserService();
            bookService = new BookService();
            loanService = new LoanService();

            this.fillWithData();
        }

        private Boolean addLoan() 
        {
            int bookId = getBookId();
            int userId = getUserId();
            if (bookId == -1 || userId == -1)
            {
                return false;
            }

            Loan loan = new Loan();
            loan.Admin = context.Admin.Find(AdminService.actualAdmin.Id);
            loan.User = context.User.Find(userId);
            loan.Book = context.Book.Find(bookId);
            loan.Loan_date = DateTime.Now;
            loan.Return_date = DateTime.Now.AddDays(90);

            context.Loan.Add(loan);
            context.SaveChanges();
            return true;
        }

        private int getBookId()
        {
            string book = (string)BookList.SelectedItem;
            if (book == null)
                return -1;
            return Int32.Parse(book.Split(' ')[0]);
        }

        private int getUserId()
        {
            string user = (string)UserList.SelectedItem;
            if (user == null)
                return -1;
            return Int32.Parse(user.Split(' ')[0]);
        }

        private void fillWithData()
        {
            List<User> users = userService.getAllUsers();
            List<Book> books = bookService.loadBooks();

            List<string> userString = new List<string>();
            foreach(User it in users)
            {
                userString.Add(it.Id + " " + it.Name + " " + it.Surname);
            }
            UserList.ItemsSource = userString;

            List<string> bookString = new List<string>();
            foreach (Book it in books)
            {
                bookString.Add(it.Id + " " + it.Title);
            }
            BookList.ItemsSource = bookString;
        }

        private void AddLoanButton(object sender, RoutedEventArgs e)
        {
            if (!this.addLoan())
                MessageBox.Show("Wybierz użytkownika oraz książkę!", "Błąd wypożyczania");
            else
                this.Close();
        }
    }
}
