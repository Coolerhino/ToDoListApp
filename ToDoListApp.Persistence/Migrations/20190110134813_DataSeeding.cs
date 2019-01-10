using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListApp.Data.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "ToDoItemId", "Description", "Done", "EstimatedFinish", "Title" },
                values: new object[] { 1, "Lotnisko Warszawa", false, new DateTime(2019, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), "Odebrać Szakala" });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "ToDoItemId", "Description", "Done", "EstimatedFinish", "Title" },
                values: new object[] { 2, "Nowy narybek", false, new DateTime(2019, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ściągnąć młodych wilków" });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "ToDoItemId", "Description", "Done", "EstimatedFinish", "Title" },
                values: new object[] { 3, "Od kochanego Waldka", false, new DateTime(2019, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "Odebrać złoto z cargo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "ToDoItemId",
                keyValue: 3);
        }
    }
}
