using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Biblioteka.users
{
    class UserService
    {
        private LibraryEntities context;

        public UserService()
        {
            context = new LibraryEntities();
        }

        public List<User> getAllUsers()
        {
            return context.User.ToList();
        }

        private Address getAddress(string street, string streetNumber, string homeNumber, string postalCode, string city)
        {
            Address address = new Address();
            address.Street = street;
            address.Street_number = streetNumber;
            address.Home_number = homeNumber;
            address.Postal_code = postalCode;
            address.City = city;

            var query = context.Address.Where(a => a.Street == address.Street);
            query = query.Where(a => a.Street_number == address.Street_number);
            query = query.Where(a => a.Home_number == address.Home_number);
            query = query.Where(a => a.Postal_code == address.Postal_code);
            query = query.Where(a => a.City == address.City);

            Address fromDB = query.FirstOrDefault();
            if (fromDB == null)
            {
                context.Address.Add(address);
                context.SaveChanges();

                var newAddress = context.Address.Where(a => a.Street == address.Street);
                newAddress = newAddress.Where(a => a.Street_number == address.Street_number);
                newAddress = newAddress.Where(a => a.Home_number == address.Home_number);
                newAddress = newAddress.Where(a => a.Postal_code == address.Postal_code);
                newAddress = newAddress.Where(a => a.City == address.City);
                return newAddress.FirstOrDefault();
            }
            else
            {
                return fromDB;
            }
        }

        public Boolean addUser(string name, string surname, string phone, string email,
            string street, string streetNumber, string homeNumber, string postalCode, string city)
        {
            User user = new User();
            user.Name = name;
            user.Surname = surname;
            user.Phone = phone;
            user.Email = email;
            user.Address = getAddress(street, streetNumber, homeNumber, postalCode, city);

            context.User.Add(user);
            context.SaveChanges();

            return true;
        }

        public Boolean removeUser(int id)
        {
            User user = context.User.Find(id);
            context.User.Remove(user);
            context.SaveChanges();

            return true;
        }
    }
}
