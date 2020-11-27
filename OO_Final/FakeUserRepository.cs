using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public class FakeUserRepository : IUserRepository
    {
        private static Dictionary<string, User> _Users;

        public FakeUserRepository()
        {
            // A temporary dictionary to fake a database
            _Users = new Dictionary<string, User>();
            _Users.Add("Anna", new User
            {
                username = "Anna",
                password = "Password1!",
                isLoggedIn = false
            });
            _Users.Add("Jason", new User
            {
                username = "Jason",
                password = "Password1!",
                isLoggedIn = false
            });
        }
        public bool Login(string UserName, string givenPassword)
        {
            bool match = false;
            User User;
            if (_Users.TryGetValue(UserName, out User))
            {
                match = User.password == givenPassword;
            }
            return match;
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            _Users[UserName].isLoggedIn = IsAuthenticated;
        }
        public List<User> GetAll()
        {
            List<User> Users = new List<User>();
            foreach (User User in _Users.Values)
            {
                Users.Add(User);
            }
            return Users;
        }
        public User GetByUserName(string UserName)
        {
            User curUser;
            try
            {
                curUser = _Users[UserName];
            }
            catch
            {
                curUser = null;
            }
            return curUser;
        }
    }
}