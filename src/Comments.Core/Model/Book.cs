namespace SusilEdizioni.Core.Model
{
    public enum PublishedType { Libro, Ebook, Articolo }
    public enum Genre { Non_Definito, Saggio_Fotografico, Poesia_Fotografia, Libro_Illustrato, Narrativa, Poesia, Saggio, Libro_Fotografico, Altro }
    public enum Method { Total_Publishing, Fifty_Publishing, Total_Fifty_Publishing }
    public enum AuthorRole { Autore, Referente}
    public enum Package { Brossura_Fresata_Dorso_Quadro, Brossura_Cucitura_Filo_Refe_Dorso_Quadro, Brossura_Dorso_Quadro, Punti_Metallici}
    public enum Cover { Lucido_Extra_White, Bianco_Opaco, Edizioni_Avorio, Edizioni_Avorio_Opaco, 
                        Lavorato_Avorio, Lucido, Lucido_Avorio, Patinato_Lucido, Patinato_Satinato,
                        Uso_Mano_Bianco_Extra_White, Uso_Mano_Bianco_Satinato}
    public enum Grammage { gr70, gr80, gr90, gr100, gr110, gr120, gr130, gr150, gr170, gr190, gr200, gr230, gr250, gr270, gr290, gr300, gr350}
    public enum Print { Colori4_0, Colori, Bianco_Nero, Bianco_Nero_Foto, Bianco_Nero_Illustrazioni, Bianco_Nero_Foto_Illustrazioni,
                        Bianco_Nero_Foto_Colori, Bianco_Nero_Illustrazioni_Colori, Bianco_Nero_Foto_Illustrazioni_Colori}


    public class Book
    {
        public int _id;
        public int? _userID;
        public PublishedType _publishedType;
        public Genre _genre;
        public DateTime _datePublished;
        public Method _method;
        public bool _hasWebSite;
        public string _title;
        public string _subtitle;
        public string _description;
        public bool _isActive;
        public decimal _price;
        public decimal _weight;
        public decimal _discountRate;
        public string _format;
        public int _pageNumber;
        public string _arguments;
        public string _authorName;
        public string _authorSurname;
        public AuthorRole _role;
        public decimal _saleRate;
        public Package _package;
        public Cover _cover;
        public Grammage _grammage;
        public Print _print;

        public Book(int id, int? userID, 
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
            _id = id;
            _userID = userID;
            _publishedType = publishedType;
            _genre = genre;
            _datePublished = datePublished;
            _method = method;
            _hasWebSite = hasWebSite;
            _title = title;
            _subtitle = subtitle;
            _description = description;
            _isActive = isActive;
            _price = price;
            _weight = weight;
            _discountRate = discountRate;
            _format = format;
            _pageNumber = pageNumber;
            _arguments = arguments;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _role = role;
            _saleRate = saleRate;
            _package = package;
            _cover = cover;
            _grammage = grammage;
            _print = print;
        }
    }
}