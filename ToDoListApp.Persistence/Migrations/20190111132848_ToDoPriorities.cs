using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListApp.Data.Migrations
{
    public partial class ToDoPriorities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "ToDoItems",
                nullable: false,
                defaultValue: 0);

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
                column: "Priority",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "ToDoItems");
        }
    }
}
