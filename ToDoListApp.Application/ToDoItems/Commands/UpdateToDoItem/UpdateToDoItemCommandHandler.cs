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
            var entity = await _context.ToDoItems.FindAsync(request.ToDoItemId);
            if (entity == null)
            {
                throw new NotFoundException(nameof(ToDoItem), request.ToDoItemId);
            }
            //use automapper here
            entity.Title = request.Title;
            entity.Description = request.Description;
            entity.EstimatedFinish = request.EstimatedFinish;
            entity.Done = request.Done;
            entity.Priority = request.Priority;

            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}