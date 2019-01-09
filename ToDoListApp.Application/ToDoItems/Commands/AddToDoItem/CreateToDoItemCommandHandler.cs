using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Commands.AddToDoItem
{
    public class CreateToDoItemCommandHandler : IRequestHandler<CreateToDoItemCommand, int>
    {
        private readonly ToDoDbContext _context;

        public CreateToDoItemCommandHandler(ToDoDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = new ToDoItem
            {
                Title = request.Title,
                Description = request.Description,
                EstimatedFinish = request.EstimatedFinish,
                Done = false
            };
            _context.ToDoItems.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.ToDoItemId;
        }
    }
}