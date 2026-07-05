using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class UserManager
    {
        private List<User> _users = new List<User>();

        public bool Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Username or password cannot be empty.");

            if (_users.Exists(u => u.Username == username))
                return false; // Username already exists.

            _users.Add(new User { Username = username, Password = password });
            return true;
        }

        public bool Login(string username, string password)
        {
            return _users.Exists(u => u.Username == username && u.Password == password);
        }


    }
}
