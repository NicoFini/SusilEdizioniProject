using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SunsilEdizioni.DB.Model
{
    [Table("Users")]
    public class UsersEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("surname")]
        public string Surname { get; set; }

        //[Column("comment"), StringLength(200), DataType(DataType.Text)]
        //public string Comment { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("isAdmin")]
        public bool IsAdmin { get; set; }
    }
}

