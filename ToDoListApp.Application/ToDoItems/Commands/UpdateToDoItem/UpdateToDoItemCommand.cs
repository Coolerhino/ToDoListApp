using System;
using MediatR;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Domain.Enums;

namespace ToDoListApp.Application.ToDoItems.Commands.UpdateToDoItem
{
    public class UpdateToDoItemCommand : IRequest
    {
        public ToDoItem ToDoItem { get; set; }
        public string ToDoItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EstimatedDate { get; set; }
        public string EstimatedTime { get; set; }
        public DateTime EstimatedFinish { get; set; }
        public Priority Priority { get; set; }
        public bool Done { get; set; }
    }
}