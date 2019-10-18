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

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        private LibraryEntities context = new LibraryEntities();
        public AddBookWindow()
        {
            InitializeComponent();
            this.initCategories();
        }

        private void initCategories()
        {
            List<string> categories = new List<string>();
            List<Category> categoriesList = context.Category.ToList();

            foreach (Category it in categoriesList)
                categories.Add(it.Name);

            categoryText.ItemsSource = categories;
            categoryText.SelectedItem = categories[0];
        }

        private void AddBookButton(object sender, RoutedEventArgs e)
        {
            this.AddAuthors(authorsText.Text);

            Book book = new Book();
            book.Title = titleText.Text;
            book.Isbn = isbnText.Text;
            book.Description = descriptionText.Text;

            try
            {
                book.Year = DateTime.Parse(yearText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niepoprawny format daty! (DD-MM-YYYY)", "Błąd daty");
                return;
            }
            
            book.Year = DateTime.Parse(yearText.Text);
            book.Publishing_house = publishingHouseText.Text;
            book.Category = getCategory((string)categoryText.SelectedItem);

            context.Book.Add(book);
            context.SaveChanges();

            this.connectAuthorsWithBook(book, authorsText.Text);
            this.Close();
        }

        private void connectAuthorsWithBook(Book book, string authors)
        {
            List<Author> authorsList = parseAuthors(authors);
            foreach(Author it in authorsList)
            {
                Author_book connection = new Author_book();
                connection.Author = it;
                connection.Book = book;

                context.Author_book.Add(connection);
                context.SaveChanges();
            }
        }

        private Category getCategory(string category)
        {
            return context.Category.Where(c => c.Name == category).FirstOrDefault();
        }

        private void AddAuthors(string authorsString)
        {
            List<Author> authors = parseAuthors(authorsString);
            foreach (Author it in authors)
            {
                if (context.Author.Where(a => a.Name == it.Name).Where(a => a.Surname == it.Surname).FirstOrDefault() == null)
                {
                    context.Author.Add(it);
                    context.SaveChanges();
                }
            }
        }

        private List<Author> parseAuthors(string authorsString)
        {
            List<Author> authors = new List<Author>();
            string[] splited = authorsString.Split(',');
            foreach(string it in splited)
            {
                string[] words = it.Split(' ');
                Author author = new Author();
                author.Name = words[0];

                for (int i = 1; i < words.Length; ++i)
                    author.Surname += words[i];

                authors.Add(author);
            }
            return authors;
        }
    }
}
