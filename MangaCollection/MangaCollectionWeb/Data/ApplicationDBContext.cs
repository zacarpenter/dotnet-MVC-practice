using MangaCollectionWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MangaCollectionWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
