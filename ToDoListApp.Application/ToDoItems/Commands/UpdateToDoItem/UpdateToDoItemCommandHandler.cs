using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoListApp.Application.Exceptions;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Commands.UpdateToDoItem
{
    public class UpdateToDoItemCommandHandler : IRequestHandler<UpdateToDoItemCommand, Unit>
    {
        private readonly ToDoDbContext _context;

        public UpdateToDoItemCommandHandler(ToDoDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.ToDoItems.FindAsync(request.ToDoItem.ToDoItemId);
            if (entity == null)
            {
                throw new NotFoundException(nameof(ToDoItem), request.ToDoItemId);
            }
            entity.Title = request.ToDoItem.Title;
            entity.Description = request.ToDoItem.Description;
            entity.EstimatedFinish = request.ToDoItem.EstimatedFinish;
            entity.Done = request.ToDoItem.Done;
            entity.Priority = request.ToDoItem.Priority;

            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}