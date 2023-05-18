using SusilEdizioni.Core.Model;

namespace SusilEdizioni.Core.Service
{
    public interface StorageServiceBooks
    {
        Book CreateBook(int id, string title, string author, decimal price, string publicher, int yearPublished, string ISBN);

        List<Book> GetBook();

        Book GetBook(int id);

        Book EditBook(Book Book);

        bool DeleteBook(int id);
    }
}
