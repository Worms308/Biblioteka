using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Biblioteka.admins;

namespace Biblioteka.login
{
    class LoginService
    {
        private LibraryEntities context;
        public LoginService()
        {
            context = new LibraryEntities();
        }

        string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public Boolean authorize(String login, String password)
        {
            MD5 algoritm = MD5.Create();
            password = GetMd5Hash(algoritm, password);
            Admin admin = context.Admin.Where(a => a.Login == login).FirstOrDefault<Admin>();
            if (admin == null)
            {
                return false;
            }
            else
            {
                if (admin.Password.Equals(password))
                {
                    admin.Last_login = System.DateTime.Now;
                    AdminService.actualAdmin = admin;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        
    }
}
