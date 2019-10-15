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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy user.xaml
    /// </summary>
    public partial class user : Page
    {
        private UserService userService;

        public user()
        {
            InitializeComponent();
            this.userService = new UserService();
            this.loadUsers();
        }

        public void loadUsers()
        {
            List<User> users = userService.getAllUsers();
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach (User it in users)
            {
                userDTOs.Add(UserTransformer.CreateDto(it));
            }
            userTable.ItemsSource = userDTOs;
        }

        private void AddUserButton(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.Show();
            this.loadUsers();
        }
    }
}
