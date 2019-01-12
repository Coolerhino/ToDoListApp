using System;
using MediatR;
using ToDoListApp.Domain.Enums;

namespace ToDoListApp.Application.ToDoItems.Commands.AddToDoItem
{
    public class CreateToDoItemCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string EstimatedDate { get; set; }
        public string EstimatedTime { get; set; }
        public Priority Priority { get; set; }
        public DateTime EstimatedFinish { get; set; }
    }
}