using Microsoft.EntityFrameworkCore;
using ToDoListApp.Domain.Entities;

namespace ToDoListApp.Persistence
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