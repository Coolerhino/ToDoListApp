using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoListApp.Application.Exceptions;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Queries.GetToDoItem
{
    public class GetToDoItemQueryHandler : IRequestHandler<GetToDoItemQuery, ToDoItem>
    {
        private readonly ToDoDbContext _context;

        public GetToDoItemQueryHandler(ToDoDbContext context)
        {
            _context = context;
        }

        public async Task<ToDoItem> Handle(GetToDoItemQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.FindAsync<ToDoItem>(request.ToDoItemId);
            if (entity == null)
            {
                throw new NotFoundException(nameof(ToDoItem), request.ToDoItemId);
            }

            return entity;
        }
    }
}