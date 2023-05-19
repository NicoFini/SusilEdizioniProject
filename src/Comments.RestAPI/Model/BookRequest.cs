using SusilEdizioni.Core.Model;
using System.ComponentModel;

namespace SusilEdizioni.RestAPI.Model
{
    public class BookRequest
    {
        [DisplayName("id")]
        public int Id { get; set; }

        [DisplayName("userID")]
        public int? UserID { get; set; }

        [DisplayName("publishedType")]
        public PublishedType PublishedType { get; set; }

        [DisplayName("datePublished")]
        public DateTime DatePublished { get; set; }

        [DisplayName("genre")]
        public Genre Genre { get; set; }

        [DisplayName("method")]
        public Method Method { get; set; }

        [DisplayName("hasWebSite")]
        public bool HasWebSite { get; set; }

        [DisplayName("title")]
        public string Title { get; set; }

        [DisplayName("subtitle")]
        public string Subtitle { get; set; }

        [DisplayName("description")]
        public string Description { get; set; }

        [DisplayName("isActive")]
        public bool IsActive { get; set; }

        [DisplayName("price")]
        public decimal Price { get; set; }

        [DisplayName("weight")]
        public decimal Weight { get; set; }

        [DisplayName("discountRate")]
        public decimal DiscountRate { get; set; }

        [DisplayName("format")]
        public string Format { get; set; }

        [DisplayName("pageNumber")]
        public int PageNumber { get; set; }

        [DisplayName("arguments")]
        public string Arguments { get; set; }

        [DisplayName("authorName")]
        public string AuthorName { get; set; }

        [DisplayName("authorSurname")]
        public string AuthorSurname { get; set; }

        [DisplayName("role")]
        public AuthorRole Role { get; set; }

        [DisplayName("saleRate")]
        public decimal SaleRate { get; set; }

        [DisplayName("package")]
        public Package Package { get; set; }

        [DisplayName("Cover")]
        public Cover Cover { get; set; }

        [DisplayName("Grammage")]
        public Grammage Grammage { get; set; }

        [DisplayName("Print")]
        public Print Print { get; set; }
    }
}
