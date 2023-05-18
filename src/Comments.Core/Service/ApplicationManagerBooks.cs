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

        public Book CreateBook(int id, string title, string author, decimal price, string publicher, int yearPublished, string ISBN)
        {
            return _storageServiceBooks.CreateBook(id, title, author, price, publicher, yearPublished, ISBN);
        }

        public Book EditBook(Book Book)
        {
            return _storageServiceBooks.EditBook(Book);
        }

        public bool DeleteBook(int id) => _storageServiceBooks.DeleteBook(id);
    }
}
