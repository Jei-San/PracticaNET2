using Microsoft.EntityFrameworkCore;
using PracticaNET2.Entities;

namespace PracticaNET2.Context
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer("Data Source = localhost\\SQLEXPRESS; Initial Catalog = test; User Id = sc; Password = 123456; TrustServerCertificate = True;");
        }

        public DbSet<Person> People { get; set; }
        //seeders
        //Jason 12
    }
}
