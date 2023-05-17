using SunsilEdizioni.Core.Model;
using SunsilEdizioni.DB.Model;

namespace SunsilEdizioni.DB.Mapper
{
    public class UsersEntityMapper
    {
        public static User From(UsersEntity entity)
        {
            return new User(entity.Id, entity.Name, entity.Surname, entity.Email, entity.Password, entity.IsAdmin);
        }
    }
}

