using System;
using MediatR;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Commands.UpdateToDoItem
{
    public class UpdateToDoItemCommand : IRequest
    {
        public string ToDoItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedFinish { get; set; }
        public bool Done { get; set; }
    }
}