using System.Collections.Generic;
using ToDoListApp.Domain.Entities;

namespace ToDoListApp.Application.ToDoItems.Queries
{
    public class ToDoItemViewModel
    {
        public IEnumerable<ToDoItem> ToDoItems { get; set; }

    }
}