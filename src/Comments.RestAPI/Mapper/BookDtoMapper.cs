using SusilEdizioni.Core.Model;
using SusilEdizioni.RestAPI.Model;

namespace SusilEdizioni.RestAPI.Mapper
{
    public class BookDtoMapper
    {
        public static BookDto From(Book book) => new BookDto
        {
            Id = book._id,
            Title = book._title,
            Author = book._author,
            Price = book._price,
            Publisher = book._publisher,
            YearPublished = book._yearPublished,
            ISBN = book._ISBN
        };
    }
}
