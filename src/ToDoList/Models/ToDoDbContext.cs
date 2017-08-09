using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoListWithMigrations.Models
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext()
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoList;integrated security=True");
        }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}