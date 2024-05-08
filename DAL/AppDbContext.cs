using Microsoft.EntityFrameworkCore;
using TaskMVC.Models;

namespace TaskMVC.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OrganicVegetable> OrganicVegetables { get; set; }
		public DbSet<Farmer> Farmers { get; set; }
	}
}
