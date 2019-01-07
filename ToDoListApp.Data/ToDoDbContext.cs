using Microsoft.EntityFrameworkCore;
using ToDoListApp.Data.Entities;

namespace ToDoListApp.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
        : base(options)
        {
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}