using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SusilEdizioni.Core.Model;

namespace SusilEdizioni.DB.Model
{
    [Table("Books")]
    public class BooksEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("userID")]
        public int? UserID { get; set; }

        [Column("publishedType")]
        public PublishedType PublishedType { get; set; }

        [Column("datePublished")]
        public DateTime DatePublished { get; set; }

        [Column("genre")]
        public Genre Genre { get; set; }

        [Column("method")]
        public Method Method { get; set; }

        [Column("hasWebSite")]
        public bool HasWebSite { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("subtitle")]
        public string Subtitle { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("isActive")]
        public bool IsActive { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("weight")]
        public decimal Weight { get; set; }

        [Column("discountRate")]
        public decimal DiscountRate { get; set; }

        [Column("format")]
        public string Format { get; set; }

        [Column("pageNumber")]
        public int PageNumber { get; set; }

        [Column("arguments")]
        public string Arguments { get; set; }

        [Column("authorName")]
        public string AuthorName { get; set; }

        [Column("authorSurname")]
        public string AuthorSurname { get; set; }

        [Column("role")]
        public AuthorRole Role { get; set; }

        [Column("saleRate")]
        public decimal SaleRate { get; set; }

        [Column("package")]
        public Package Package { get; set; }

        [Column("Cover")]
        public Cover Cover { get; set; }

        [Column("Grammage")]
        public Grammage Grammage { get; set; }

        [Column("Print")]
        public Print Print { get; set; }

    }
}
