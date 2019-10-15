using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.users
{
    static class UserTransformer
    {
        public static UserDTO CreateDto(User user) 
        {
            UserDTO dto = new UserDTO();
            dto.Id = user.Id;
            dto.Name = user.Name;
            dto.Surname = user.Surname;
            dto.Phone = user.Phone;
            dto.Email = user.Email;
            dto.Address = user.Address.Street + " " +
                        user.Address.Street_number + " " +
                        user.Address.Home_number + " " +
                        user.Address.City + " " +
                        user.Address.Postal_code;
            return dto;
        }
    }
}
