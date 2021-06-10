using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class User
    {
        private string username;
        private string password;
        public User(string s1,string s2)
        {
            this.username = s1;
            this.password = s2;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
