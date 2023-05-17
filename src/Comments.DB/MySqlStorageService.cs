using System;
using System.Linq;
using SunsilEdizioni.Core.Exceptions;
using SunsilEdizioni.Core.Model;
using SunsilEdizioni.Core.Service;
using SunsilEdizioni.DB.Model;
using SunsilEdizioni.DB.Mapper;
using SunsilEdizioni.DB;

namespace SunsilEdizioni.DB
{
    public class MySqlStorageService : StorageServiceUsers
    { 
        private SunsilEdizioniDBContext _context;

        public MySqlStorageService()
        {
            _context = new();
            _context.Database.EnsureCreated();
        }

        public bool DeleteUser(int id)
        {
            var userToDelete = GetUserOrFail(id);

            _context.Users.Remove(userToDelete);
            _context.SaveChanges();

            return true;
        }

        public User CreateUser(int id, string name, string surname, string email, string password, bool isAdmin)
        {
            UsersEntity createUser = new UsersEntity
            {              
                Id = id,
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                IsAdmin = isAdmin
            };

            /*_id = id;
            _name = name;
            _surname = surname;
            _email = email;
            _password = password;
            _isAdmin = isAdmin;*/

            _context.Users.Add(createUser);
            _context.SaveChanges();

            return UsersEntityMapper.From(createUser);
        }

        public List<User> GetUser() =>
            _context.Users.Select(CommentsEntry => UsersEntityMapper.From(CommentsEntry)).ToList();

        public User GetUser(int id)
        {
            var c = GetUserOrFail(id);
            return UsersEntityMapper.From(c);
        }

        public User EditUser(User body)
        {
            UsersEntity ModifiedUser = GetUserOrFail(body._id);
            ModifiedUser.Id = body._id;

            _context.SaveChanges();
            return UsersEntityMapper.From(ModifiedUser);
        }


        private UsersEntity GetUserOrFail(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null) throw new UserNotFound(id);
            return user;
        }        
    }
}
