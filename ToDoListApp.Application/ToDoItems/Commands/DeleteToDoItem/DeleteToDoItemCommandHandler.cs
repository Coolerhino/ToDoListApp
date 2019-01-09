using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoListApp.Application.Exceptions;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Commands.DeleteToDoItem
{
    public class DeleteToDoItemCommandHandler : IRequestHandler<DeleteToDoItemCommand>
    {
        private readonly ToDoDbContext _context;

        public DeleteToDoItemCommandHandler(ToDoDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteToDoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.ToDoItems.FindAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(ToDoItem), request.Id);
            }

            _context.ToDoItems.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}