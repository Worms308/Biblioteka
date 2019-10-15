using Biblioteka.admins;
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
    /// Logika interakcji dla klasy admin.xaml
    /// </summary>
    public partial class admin : Page
    {

        private AdminService adminService;
        public admin()
        {
            InitializeComponent();
            adminService = new AdminService();
            this.loadAdmins();
        }

        public void loadAdmins()
        {
            List<Admin> admins = adminService.loadAdmins();
            List<AdminDTO> adminDTOs = new List<AdminDTO>();
            foreach(Admin it in admins)
            {
                adminDTOs.Add(AdminTransformer.createDto(it));
            }

            adminTable.ItemsSource = adminDTOs;
        }
    }
}
