using SusilEdizioni.Core.Model;
using SusilEdizioni.Core.Service;

namespace SusilEdizioni.Core
{
    public class ApplicationManagerUsers
    {
        StorageServiceUsers _storageServiceUsers;
        public ApplicationManagerUsers(StorageServiceUsers storageServiceUsers)
        {
            _storageServiceUsers = storageServiceUsers;
        }
        public List<User> GetAllUsers() => _storageServiceUsers.GetUser();

        public bool IsUsersListEmpty() => GetAllUsers().Count == 0;

        public User GetUser(int id) => _storageServiceUsers.GetUser(id);

        public User CreateUser(int id, string name, string surname, string email, string password, bool isAdmin, int? bookID)
        {
            return _storageServiceUsers.CreateUser(id, name, surname, email, password, isAdmin, bookID);   
        }

        public User EditUser(User user)
        {
            return _storageServiceUsers.EditUser(user);
        }

        public bool DeleteUser(int id) => _storageServiceUsers.DeleteUser(id);
    }
}
