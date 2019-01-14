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
                Priority = Priority.Medium
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 2,
                Title = "Ściągnąć młodych wilków",
                Description = "Nowy narybek",
                EstimatedFinish = new DateTime(2019, 01, 16, 14, 0, 0),
                Priority = Priority.Low
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 3,
                Title = "Odebrać złoto z cargo",
                Description = "Od kochanego Waldka",
                EstimatedFinish = new DateTime(2019, 01, 8, 20, 0, 0),
                Priority = Priority.Low
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 4,
                Title = "Task 1",
                Description = "Pojedyncze zadanie zawiera tytuł, opis oraz przewidywaną datę zakończenia",
                EstimatedFinish = new DateTime(2019, 01, 9, 18, 0, 0),
                Priority = Priority.High,
                Done = true
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 5,
                Title = "Task 2",
                Description = "Możliwe jest dodawanie/edytowanie/usuwanie zadań z listy",
                EstimatedFinish = new DateTime(2019, 01, 10, 17, 0, 0),
                Priority = Priority.High,
                Done = true
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 6,
                Title = "Task 3",
                Description = "Możliwe jest oznaczanie zadania jako zakończone/niezakończone",
                EstimatedFinish = new DateTime(2019, 01, 11, 21, 0, 0),
                Priority = Priority.High,
                Done = true
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 7,
                Title = "Task 4",
                Description = "Możliwe jest ustawienie priorytetu zadania (w przypadku wyższego priorytetu zadaniezostaje wyróżnione oraz przeskakuje na górę listy)",
                EstimatedFinish = new DateTime(2019, 01, 12, 21, 30, 0),
                Priority = Priority.High,
                Done = true
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 8,
                Title = "Task 5",
                Description = "Lista zadań posiada paginację",
                EstimatedFinish = new DateTime(2019, 01, 13, 23, 0, 0),
                Priority = Priority.High,
                Done = true
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 9,
                Title = "Task 6",
                Description = "Możliwe jest przefiltrowanie listy zadań wg. filtrów: wszystkie, niezakończone, zakończone",
                EstimatedFinish = new DateTime(2019, 01, 13, 15, 0, 0),
                Priority = Priority.High,
                Done = true
            });
            modelBuilder.Entity<ToDoItem>().HasData(new ToDoItem
            {
                ToDoItemId = 10,
                Title = "Task 7",
                Description = "Możliwe jest przeszukiwanie listy zadań po tytule oraz opisie",
                EstimatedFinish = new DateTime(2019, 01, 13, 14, 0, 0),
                Priority = Priority.High,
                Done = true
            });
        }
    }
}