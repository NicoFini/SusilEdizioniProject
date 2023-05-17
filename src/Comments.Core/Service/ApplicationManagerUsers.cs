using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SunsilEdizioni.Core.Exceptions;
using SunsilEdizioni.Core.Model;
using SunsilEdizioni.Core.Service;

namespace SunsilEdizioni.Core
{
    public class ApplicationManagerUsers
    {
        StorageServiceUsers _storageServiceComments;
        public ApplicationManagerUsers(StorageServiceUsers storageServiceComments)
        {
            _storageServiceComments = storageServiceComments;
        }
        public List<User> GetAllUsers() => _storageServiceComments.GetUser();

        public bool IsCommentsListEmpty() => GetAllUsers().Count == 0;

        public User GetUser(int id) => _storageServiceComments.GetUser(id);

        public User CreateUser(int id, string name, string surname, string email, string password, bool isAdmin)
        {
            return _storageServiceComments.CreateUser(id, name, surname, email, password, isAdmin);   
        }

        public User EditComment(User user)
        {
            return _storageServiceComments.EditUser(user);
        }

        public bool DeleteUser(int id) => _storageServiceComments.DeleteUser(id);
    }
}
