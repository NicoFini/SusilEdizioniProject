using SusilEdizioni.Core.Model;
using SusilEdizioni.RestAPI.Model;
using System.Net;

namespace SusilEdizioni.RestAPI.Mapper
{
    public class BookDtoMapper
    {
        public static BookDto From(Book book) => new BookDto
        {
            Id = book._id,
            UserID = book?._userID,
            PublishedType = book._publishedType,
            Genre = book._genre,
            DatePublished = book._datePublished,
            Method = book._method,
            HasWebSite = book._hasWebSite,
            Title = book._title,
            Subtitle = book._subtitle,
            Description = book._description,
            IsActive = book._isActive,
            Price = book._price,
            Weight = book._weight,
            DiscountRate = book._discountRate,
            Format = book._format,
            PageNumber = book._pageNumber,
            Arguments = book._arguments,
            AuthorName = book._authorName,
            AuthorSurname = book._authorSurname,
            Role = book._role,
            SaleRate = book._saleRate,
            Package = book._package,
            Cover = book._cover,
            Grammage = book._grammage,
            Print = book._print,
        };
    }
}
