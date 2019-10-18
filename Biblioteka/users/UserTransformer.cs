using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.users
{
    static class UserTransformer
    {
        private static LibraryEntities context = new LibraryEntities();
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

        public static UserDTOLoan userDTOLoan(User user)
        {
            UserDTOLoan userDTOLoan = new UserDTOLoan();
            userDTOLoan.Id = user.Id;
            userDTOLoan.Name = user.Name;
            userDTOLoan.Surname = user.Surname;

            return userDTOLoan;
        }

        public static User CreateEntity(UserDTO userDTO)
        {
            User user = context.User.Where(u => u.Id == userDTO.Id).FirstOrDefault();
            return user;
        }
    }
}
