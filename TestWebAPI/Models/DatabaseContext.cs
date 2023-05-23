using Microsoft.EntityFrameworkCore;

namespace TestWebAPI.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=IEPL-YASHEN\MSSQLSERVER17;Initial Catalog=UserDetails;Integrated Security=True");
        }
    }
}
