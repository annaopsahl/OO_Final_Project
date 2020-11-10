using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    class user
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool isLoggedIn { get; set; }

        // constructor, user is not logged in
        public user()
        {
            isLoggedIn = false;
        }
    }
}
