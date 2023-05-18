using SusilEdizioni.Core.Model;
using SusilEdizioni.DB.Model;

namespace SusilEdizioni.DB.Mapper
{
    public class UsersEntityMapper
    {
        public static User From(UsersEntity entity)
        {
            return new User(entity.Id, entity.Name, entity.Surname, entity.Email, entity.Password, entity.IsAdmin);
        }
    }
}

