using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_role_based_authentication.Models;

namespace webapi_role_based_authentication.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
