using MediatR;

namespace ToDoListApp.Application.ToDoItems.Commands.DeleteToDoItem
{
    public class DeleteToDoItemCommand : IRequest
    {
        public int Id { get; set; }
    }
}