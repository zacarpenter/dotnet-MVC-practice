using Microsoft.EntityFrameworkCore;
using RazorWebDemo.Model;

namespace RazorWebDemo.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
