namespace SusilEdizioni.Core.Model
{
    public class User
    {
        public int _id;
        public string _name;
        public string _surname;
        public string _email;
        public string _password;
        public bool _isAdmin;
        public int? _bookID;

    public User(int id, string name, string surname, string email, string password, bool isAdmin, int? bookID)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _email = email;
            _password = password;
            _isAdmin = isAdmin;
            _bookID = bookID;
        }
    }
}
