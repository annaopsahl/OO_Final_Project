using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Final
{
    public interface IUserRepository
    {
        bool Login(string UserName, string Password);
        List<User> GetAll();
        void SetAuthentication(string UserName, bool IsAuthenticated);
        User GetByUserName(string UserName);
    }
}
