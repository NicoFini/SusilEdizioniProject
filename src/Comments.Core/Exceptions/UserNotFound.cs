namespace SunsilEdizioni.Core.Exceptions
{
    public class UserNotFound : Exception
    {
        public UserNotFound(int id) : base($"ser non trovato: {id}")
        {
        }
    }
}
