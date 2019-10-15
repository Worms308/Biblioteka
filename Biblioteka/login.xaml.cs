using Biblioteka.login;
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
    /// Logika interakcji dla klasy login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            String login = LoginInput.Text;
            String password = PasswordInput.Password;

            LoginService loginService = new LoginService();
            if (loginService.authorize(login, password))
            {
                ((MainWindow)Application.Current.MainWindow).selectMenu();
            }
            else
            {
                warning.Visibility = Visibility.Visible;
            }
        }
    }
}
