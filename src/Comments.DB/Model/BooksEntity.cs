using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SusilEdizioni.DB.Model
{
    [Table("Books")]
    public class BooksEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("publisher")]
        public string Publisher { get; set; }

        [Column("yearPublished")]
        public int YearPublished { get; set; }

        [Column("ISBN")]
        public string ISBN { get; set; }

        [Column("userID")]
        public int? UserID { get; set; }
    }
}
