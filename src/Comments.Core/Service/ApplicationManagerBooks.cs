using SunsilEdizioni.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsilEdizioni.Core.Service
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
