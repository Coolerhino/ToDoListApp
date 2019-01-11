using System;
using Microsoft.EntityFrameworkCore;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Domain.Enums;

namespace ToDoListApp.Persistence
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
        : base(options)
        {
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 1,
                Title = "Odebrać Szakala",
                Description = "Lotnisko Warszawa",
                EstimatedFinish = new DateTime(2019, 01, 15, 14, 0, 0),
                Priority = Priority.High
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 2,
                Title = "Ściągnąć młodych wilków",
                Description = "Nowy narybek",
                EstimatedFinish = new DateTime(2019, 01, 16, 14, 0, 0),
                Priority = Priority.Medium
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 3,
                Title = "Odebrać złoto z cargo",
                Description = "Od kochanego Waldka",
                EstimatedFinish = new DateTime(2019, 01, 16, 14, 0, 0),
                Priority = Priority.High
            });
        }
    }
}