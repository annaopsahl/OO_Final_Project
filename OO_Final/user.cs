using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool isLoggedIn { get; set; }

        // constructor, user is not logged in
        public User()
        {
            isLoggedIn = false;
        }
    }
}
