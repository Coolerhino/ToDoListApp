using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Commands.ToggleDone
{
    public class ToggleDoneCommandHandler : IRequestHandler<ToggleDoneCommand, bool>
    {
        private readonly ToDoDbContext _context;

        public ToggleDoneCommandHandler(ToDoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(ToggleDoneCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.ToDoItems.SingleOrDefaultAsync(x => x.ToDoItemId == request.ItemId, cancellationToken);
            var updatedDone = !entity.Done;
            entity.Done = updatedDone;
            _context.SaveChanges();
            return updatedDone;
        }
    }
}