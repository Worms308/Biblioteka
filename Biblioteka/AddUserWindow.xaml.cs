using Biblioteka.users;
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
    /// Logika interakcji dla klasy AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        private UserService userService;
        public AddUserWindow()
        {
            InitializeComponent();
            this.userService = new UserService();
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            userService.addUser(nameText.Text,
                surnameText.Text,
                phoneText.Text,
                emailText.Text,
                streetText.Text,
                streetNumText.Text,
                homeNumText.Text,
                postalCodeText.Text,
                cityText.Text);
            this.Close();
        }
    }
}
