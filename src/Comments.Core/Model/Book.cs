namespace SusilEdizioni.Core.Model
{
    public class Book
    {
        public int _id;
        public string _title;
        public string _author;
        public decimal _price;
        public string _publisher;
        public int _yearPublished;
        public string _ISBN;
        public int? _userID;

        public Book(int id, string title, string author, decimal price, string publisher, int yearPublished, string ISBN, int? userID)
        {
            _id = id;
            _title = title;
            _author = author;
            _price = price;
            _publisher = publisher;
            _yearPublished = yearPublished;
            _ISBN = ISBN;
            _userID = userID;
        }
    }
}