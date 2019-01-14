using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListApp.Data.Migrations
{
    public partial class ProjectTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 1,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 2,
                column: "Priority",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 3,
                columns: new[] { "EstimatedFinish", "Priority" },
                values: new object[] { new DateTime(2019, 1, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "ToDoItemId", "Description", "Done", "EstimatedFinish", "Priority", "Title" },
                values: new object[,]
                {
                    { 4, "Pojedyncze zadanie zawiera tytuł, opis oraz przewidywaną datę zakończenia", true, new DateTime(2019, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 1" },
                    { 5, "Możliwe jest dodawanie/edytowanie/usuwanie zadań z listy", true, new DateTime(2019, 1, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 2" },
                    { 6, "Możliwe jest oznaczanie zadania jako zakończone/niezakończone", true, new DateTime(2019, 1, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 3" },
                    { 7, "Możliwe jest ustawienie priorytetu zadania (w przypadku wyższego priorytetu zadaniezostaje wyróżnione oraz przeskakuje na górę listy)", true, new DateTime(2019, 1, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), 2, "Task 4" },
                    { 8, "Lista zadań posiada paginację", true, new DateTime(2019, 1, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 5" },
                    { 9, "Możliwe jest przefiltrowanie listy zadań wg. filtrów: wszystkie, niezakończone, zakończone", true, new DateTime(2019, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 6" },
                    { 10, "Możliwe jest przeszukiwanie listy zadań po tytule oraz opisie", true, new DateTime(2019, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "Task 7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 1,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 2,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 3,
                columns: new[] { "EstimatedFinish", "Priority" },
                values: new object[] { new DateTime(2019, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 2 });
        }
    }
}
