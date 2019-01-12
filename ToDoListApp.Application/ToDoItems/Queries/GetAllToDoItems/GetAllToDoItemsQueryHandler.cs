using System.Collections.Generic;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ToDoListApp.Domain.Entities;
using ToDoListApp.Persistence;

namespace ToDoListApp.Application.ToDoItems.Queries
{
    public class GetAllToDoItemsQueryHandler : IRequestHandler<GetAllToDoItemsQuery, ToDoItemsViewModel>
    {
        private readonly ToDoDbContext _context;
        private readonly IMapper _mapper;
        public GetAllToDoItemsQueryHandler(ToDoDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ToDoItemsViewModel> Handle(GetAllToDoItemsQuery request, CancellationToken cancellationToken)
        {
            var toDoItems = await _context.ToDoItems.ToListAsync(cancellationToken);
            var model = new ToDoItemsViewModel
            {
                ToDoItems = _mapper.Map<IEnumerable<ToDoItem>>(toDoItems)
            };
            return model;
        }
    }
}