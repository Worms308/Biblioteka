using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;

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

        public User getUserById(int id)
        {
            return context.User.Find(id);
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

        public Boolean changeUser(User user)
        {
            User change = context.User.Where(u => u.Id == user.Id).FirstOrDefault();
            change.Name = user.Name;
            change.Surname = user.Surname;
            change.Phone = user.Phone;
            change.Email = user.Email;

            Address address = context.Address.Where(a => a.Id == user.Address.Id).FirstOrDefault();
            address.Street = user.Address.Street;
            address.Street_number = user.Address.Street_number;
            address.Home_number = user.Address.Home_number;
            address.Postal_code = user.Address.Postal_code;
            address.City = user.Address.City;
            context.SaveChanges();
            return true;
        }
    }
}
