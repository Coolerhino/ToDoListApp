using System.Collections.Generic;
using MediatR;
using ToDoListApp.Domain.Entities;

namespace ToDoListApp.Application.ToDoItems.Queries
{
    public class GetAllToDoItemsQuery : IRequest<List<ToDoItem>>
    {
    }
}