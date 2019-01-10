using System.Collections.Generic;
using MediatR;
using ToDoListApp.Domain.Entities;

namespace ToDoListApp.Application.ToDoItems.Queries
{
    public class GetAllToDoItemsQuery : IRequest<ToDoItemViewModel>
    {
        public string SearchTitle { get; set; }
        public string SearchDescription { get; set; }
        public int? Page { get; set; }
    }
}