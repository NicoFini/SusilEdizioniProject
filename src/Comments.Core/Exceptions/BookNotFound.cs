namespace SunsilEdizioni.Core.Exceptions
{
    public class BookNotFound : Exception
    {
        public BookNotFound(int id) : base($"Book not found: {id}")
        {
        }
    }
}
