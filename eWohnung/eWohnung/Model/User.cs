using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWohnung.Model
{
    public class User
    {
        private string Username { get; set; }
        private string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
       
        public string GetUsername()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }
    }
}
