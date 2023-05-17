using SunsilEdizioni.Core.Model;
using SunsilEdizioni.RestAPI.Model;

namespace SunsilEdizioni.RestAPI.Mapper
{
    public class UserDtoMapper
    {
        public static UserDto From(User user) => new UserDto
        {
            Id = user._id,
            Name = user._name,
            Surname = user._surname,
            Email = user._email,
            Password = user._password,
            IsAdmin = user._isAdmin
        };
    }
}