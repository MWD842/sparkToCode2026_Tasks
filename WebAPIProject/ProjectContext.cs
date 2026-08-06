using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject
{
    public class ProjectContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

    }
}