using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Salary { get; set; }

        public User()
        {

        }

        public User(string name, string email, string password, int salary)
        {
            Name = name;
            Email = email;
            Password = password;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}, {Password}, {Salary}";
        }

    }
}
