using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.admins
{
    class AdminService
    {
        private LibraryEntities context;

        public AdminService()
        {
            context = new LibraryEntities();
        }

        public List<Admin> loadAdmins()
        {
            return context.Admin.ToList();
        }
    }
}
