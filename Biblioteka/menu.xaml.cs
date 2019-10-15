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
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            ContentFrame.Navigate(new System.Uri("user.xaml", UriKind.RelativeOrAbsolute));
        }


        private void SelectAdmin(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new System.Uri("admin.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SelectUser(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new System.Uri("user.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SelectBook(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new System.Uri("book.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SelectLoan(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new System.Uri("loan.xaml", UriKind.RelativeOrAbsolute));
        }

        private void LogoutButton(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).selectLogin();
        }
    }
}
