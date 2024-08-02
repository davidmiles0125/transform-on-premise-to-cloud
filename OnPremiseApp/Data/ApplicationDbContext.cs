using Microsoft.EntityFrameworkCore;
using OnPremistApp.Models;

namespace OnPremiseApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}