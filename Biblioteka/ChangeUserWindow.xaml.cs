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
    /// Logika interakcji dla klasy ChangeUserWindow.xaml
    /// </summary>
    public partial class ChangeUserWindow : Window
    {

        private User user;
        private UserService userService;
        public ChangeUserWindow()
        {
            InitializeComponent();
            userService = new UserService();
        }

        public void initData(UserDTO userDto)
        {
            this.user = UserTransformer.CreateEntity(userDto);
            nameText.Text = user.Name;
            surnameText.Text = user.Surname;
            phoneText.Text = user.Phone;
            emailText.Text = user.Email;
            streetText.Text = user.Address.Street;
            streetNumText.Text = user.Address.Street_number;
            homeNumText.Text = user.Address.Home_number;
            postalCodeText.Text = user.Address.Postal_code;
            cityText.Text = user.Address.City;
        }

        public User GetUser()
        {
            user.Name = nameText.Text;
            user.Surname = surnameText.Text;
            user.Phone = phoneText.Text;
            user.Email = emailText.Text;
            user.Address.Street = streetText.Text;
            user.Address.Street_number = streetNumText.Text;
            user.Address.Home_number = homeNumText.Text;
            user.Address.Postal_code = postalCodeText.Text;
            user.Address.City = cityText.Text;
            return user;
        }

        public void changeUser(object sender, RoutedEventArgs e)
        {
            userService.changeUser(this.GetUser());
            this.Close();
        }
    }
}
