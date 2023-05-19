using System.ComponentModel;

namespace SusilEdizioni.RestAPI.Model
{
    public class BookRequest
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("Author")]
        public string Author { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Publisher")]
        public string Publisher { get; set; }

        [DisplayName("YearPublished")]
        public int YearPublished { get; set; }

        [DisplayName("ISBN")]
        public string ISBN { get; set; }

        [DisplayName("userID")]
        public int UserID { get; set; }
    }
}
