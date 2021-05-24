using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Models
{
     class User
    {
        private string name;
        private string email;

        public User(string name,string email)
        {
            Name = name;
            Email = email;
        }

        public string Name // properties
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}
