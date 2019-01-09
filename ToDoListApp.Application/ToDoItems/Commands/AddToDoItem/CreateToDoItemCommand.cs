using System;
using MediatR;

namespace ToDoListApp.Application.ToDoItems.Commands.AddToDoItem
{
    public class CreateToDoItemCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedFinish { get; set; }
    }
}