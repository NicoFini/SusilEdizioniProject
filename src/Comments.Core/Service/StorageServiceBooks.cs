using SusilEdizioni.Core.Model;

namespace SusilEdizioni.Core.Service
{
    public interface StorageServiceBooks
    {
        Book CreateBook(int id, int? userID,
            PublishedType publishedType,
            Genre genre, DateTime datePublished,
            Method method, bool hasWebSite, string title,
            string subtitle, string description,
            bool isActive, decimal price,
            decimal weight, decimal discountRate,
            string format, int pageNumber,
            string arguments, string authorName,
            string authorSurname, AuthorRole role,
            decimal saleRate, Package package,
            Cover cover, Grammage grammage, Print print);

        List<Book> GetBook();

        Book GetBook(int id);

        Book EditBook(Book Book);

        bool DeleteBook(int id);
    }
}
