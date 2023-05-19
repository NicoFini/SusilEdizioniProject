using SusilEdizioni.Core.Exceptions;
using SusilEdizioni.Core.Model;
using SusilEdizioni.Core.Service;
using SusilEdizioni.DB.Mapper;
using SusilEdizioni.DB.Model;
using System.Data;
using System.Drawing;

namespace SusilEdizioni.DB
{
    public class MySqlStorageService : StorageServiceUsers, StorageServiceBooks
    { 
        private SusilEdizioniDBContext _context;

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

        public User CreateUser(int id, string name, string surname, string email, string password, bool isAdmin, int? bookID)
        {
            UsersEntity createUser = new UsersEntity
            {              
                Id = id,
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                IsAdmin = isAdmin,
                BookID = bookID
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
            BooksEntity createBook = new BooksEntity
                {
                Id = id,
                UserID = userID,
                PublishedType = publishedType,
                Genre = genre,
                DatePublished = datePublished,
                Method = method,
                HasWebSite = hasWebSite,
                Title = title,
                Subtitle = subtitle,
                Description = description,
                IsActive = isActive,
                Price = price,
                Weight = weight,
                DiscountRate = discountRate,
                Format = format,
                PageNumber = pageNumber,
                Arguments = arguments,
                AuthorName = authorName,
                AuthorSurname = authorSurname,
                Role = role,
                SaleRate = saleRate,
                Package = package,
                Cover = cover,
                Grammage = grammage,
                Print = print,
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
