using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.admins
{
    static class AdminTransformer
    {
        public static AdminDTO createDto(Admin admin)
        {
            AdminDTO dto = new AdminDTO();
            dto.Id = admin.Id;
            dto.Name = admin.Name;
            dto.Surname = admin.Surname;
            dto.Login = admin.Login;
            dto.Last_login = admin.Last_login;
            return dto;
        }
    }
}
