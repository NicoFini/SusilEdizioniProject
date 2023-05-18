using SunsilEdizioni.Core.Exceptions;
using SunsilEdizioni.Core.Model;
using SunsilEdizioni.Core.Service;
using SunsilEdizioni.DB.Mapper;
using SunsilEdizioni.DB.Model;

namespace SunsilEdizioni.DB
{
    public class MySqlStorageService : StorageServiceUsers, StorageServiceBooks
    { 
        private SunsilEdizioniDBContext _context;

        public MySqlStorageService()
        {
            _context = new();
            _context.Database.EnsureCreated();
        }

        #region User
        public bool DeleteUser(int id)
        {
            var userToDelete = GetUserOrFail(id);

            _context.Users.Remove(userToDelete);
            _context.SaveChanges();

            return true;
        }

        public User CreateUser(int id, string name, string surname, string email, string password, bool isAdmin)
        {
            UsersEntity createUser = new UsersEntity
            {              
                Id = id,
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                IsAdmin = isAdmin
            };

            _context.Users.Add(createUser);
            _context.SaveChanges();

            return UsersEntityMapper.From(createUser);
        }

        public List<User> GetUser() =>
            _context.Users.Select(CommentsEntry => UsersEntityMapper.From(CommentsEntry)).ToList();

        public User GetUser(int id)
        {
            var user = GetUserOrFail(id);
            return UsersEntityMapper.From(user);
        }

        public User EditUser(User body)
        {
            UsersEntity ModifiedUser = GetUserOrFail(body._id);
            ModifiedUser.Id = body._id;

            _context.SaveChanges();
            return UsersEntityMapper.From(ModifiedUser);
        }

        private UsersEntity GetUserOrFail(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null) throw new UserNotFound(id);
            return user;
        }
        #endregion

        #region Book
        public bool DeleteBook(int id)
        {
            var BookToDelete = GetBookOrFail(id);

            _context.Books.Remove(BookToDelete);
            _context.SaveChanges();

            return true;
        }

        public Book CreateBook(int id, string title, string author, decimal price, string publisher, int yearPublished, string ISBN)
        {
            BooksEntity createBook = new BooksEntity
                {
                Id = id,
                Title = title,
                Author = author,
                Price = price,
                Publisher = publisher,
                YearPublished = yearPublished,
                ISBN = ISBN
            };

            _context.Books.Add(createBook);
            _context.SaveChanges();

            return BooksEntityMapper.From(createBook);
        }

        public List<Book> GetBook() =>
            _context.Books.Select(CommentsEntry => BooksEntityMapper.From(CommentsEntry)).ToList();

        public Book GetBook(int id)
        {
            var book = GetBookOrFail(id);
            return BooksEntityMapper.From(book);
        }

        public Book EditBook(Book body)
        {
            BooksEntity ModifiedBook = GetBookOrFail(body._id);
            ModifiedBook.Id = body._id;

            _context.SaveChanges();
            return BooksEntityMapper.From(ModifiedBook);
        }

        private BooksEntity GetBookOrFail(int id)
        {
            var Book = _context.Books.Find(id);

            if (Book == null) throw new BookNotFound(id);
            return Book;
        }
        #endregion

    }
}
