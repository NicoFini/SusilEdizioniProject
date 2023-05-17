using Microsoft.EntityFrameworkCore;
using SunsilEdizioni.DB.Model;

namespace SunsilEdizioni.DB
{
{
    public class SunsilEdizioniDBContext : DbContext
    {
        public DbSet<UsersEntity>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var version = new MySqlServerVersion(new Version(8, 0, 30));
            var connectionString = "Server=localhost;Port=3306;Database=SunsilEdizioni;Uid=root;Pwd=MySQL6610639!";

            optionsBuilder.UseMySql(connectionString, version);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
