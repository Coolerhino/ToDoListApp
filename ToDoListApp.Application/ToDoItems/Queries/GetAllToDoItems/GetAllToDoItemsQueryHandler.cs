using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Queries
{
    public class GetAllToDoItemsQueryHandler : IRequestHandler<GetAllToDoItemsQuery, List<ToDoItem>>
    {
        private readonly ToDoDbContext _context;
        public GetAllToDoItemsQueryHandler(ToDoDbContext context)
        {
            _context = context;
        }
        public async Task<List<ToDoItem>> Handle(GetAllToDoItemsQuery request, CancellationToken cancellationToken)
        {
            var toDoItems = await _context.ToDoItems.ToListAsync(cancellationToken);
            return toDoItems;
        }
    }
}