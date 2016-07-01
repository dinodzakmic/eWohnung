using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWohnung.Model
{
    class UserTest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<RegioniDjelovanja> RegioniDjelovanja { get; set; }
        public string Email { get; set; }

        public UserTest(int id, string name, string surname, string username, string password, List<RegioniDjelovanja> regioniDjelovanja, string email )
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            RegioniDjelovanja = regioniDjelovanja;
            Email = email;
        }
    }

    public class RegioniDjelovanja
    {
        public string Naziv { get; set; }
    }
}
