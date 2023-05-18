using Microsoft.EntityFrameworkCore;
using SusilEdizioni.DB.Model;

namespace SusilEdizioni.DB
{
    public class SusilEdizioniDBContext : DbContext
    {
        public DbSet<UsersEntity>? Users { get; set; }
        public DbSet<BooksEntity>? Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var version = new MySqlServerVersion(new Version(8, 0, 30));
            var connectionString = "Server=localhost;Port=3306;Database=SusilEdizioni;Uid=root;Pwd=MySQL6610639!";

            optionsBuilder.UseMySql(connectionString, version);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
