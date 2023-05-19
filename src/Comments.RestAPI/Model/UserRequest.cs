using System.ComponentModel;

namespace SusilEdizioni.RestAPI.Model
{
    public class UserRequest
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Surname")]
        public string Surname { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("IsAdmin")]
        public bool IsAdmin { get; set; }

        [DisplayName("bookID")]
        public int? BookID { get; set; }
    }
}