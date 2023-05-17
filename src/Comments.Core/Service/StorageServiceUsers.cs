using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsilEdizioni.Core.Model;
using SunsilEdizioni.Core.Model;

namespace SunsilEdizioni.Core.Service
{
    public interface StorageServiceUsers
    {
        User CreateUser(int id, string name, string surname, string email, string password, bool isAdmin);

        List<User> GetUser();

        User GetUser(int id);

        User EditUser(User user);

        bool DeleteUser(int id);
    }
}

