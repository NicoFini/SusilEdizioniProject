using SusilEdizioni.Core.Model;
using SusilEdizioni.Core.Service;

namespace SusilEdizioni.Core
{
    public class ApplicationManagerBooks
    {
        StorageServiceBooks _storageServiceBooks;
        public ApplicationManagerBooks(StorageServiceBooks storageServiceBooks)
        {
            _storageServiceBooks = storageServiceBooks;
        }
        public List<Book> GetAllBooks() => _storageServiceBooks.GetBook();

        public bool IsBooksListEmpty() => GetAllBooks().Count == 0;

        public Book GetBook(int id) => _storageServiceBooks.GetBook(id);

        public Book CreateBook(int id, int? userID,
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
            Cover cover, Grammage grammage, Print print)
        {
            return _storageServiceBooks.CreateBook( id, userID,  publishedType,  genre,  datePublished,  method,  hasWebSite,  title,
                 subtitle,  description,  isActive,  price,  weight,  discountRate,  format,
                 pageNumber,  arguments,  authorName,  authorSurname,  role,  saleRate,  package,
                 cover,  grammage,  print);
        }

        public Book EditBook(Book Book)
        {
            return _storageServiceBooks.EditBook(Book);
        }

        public bool DeleteBook(int id) => _storageServiceBooks.DeleteBook(id);
    }
}
