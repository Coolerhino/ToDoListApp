using MediatR;
using ToDoListApp.Domain.Entities;

namespace ToDoListApp.Application.ToDoItems.Queries.GetToDoItem
{
    public class GetToDoItemQuery : IRequest<ToDoItem>
    {
        public int ToDoItemId { get; set; }
    }
}