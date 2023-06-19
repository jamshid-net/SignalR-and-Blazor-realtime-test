using Microsoft.EntityFrameworkCore;

namespace RealtimeDataApp.Data
{
    public class AppDbContext : DbContext
    {
        string _connectionString = "Server=JAMSHID-PC\\SQLEXPRESS;Database=CompanyDatabase;Trusted_Connection=True;Encrypt=False;";

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
