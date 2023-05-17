namespace SunsilEdizioni.Core.Exceptions
{
    public class UserNotFound : Exception
    {
        public UserNotFound(int id) : base($"user not found: {id}")
        {
        }
    }
}
