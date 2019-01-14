using System;
using System.Collections.Generic;
using System.Linq;
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

            var toDoItems = _context.ToDoItems.Select(x => x);
            if (!string.IsNullOrWhiteSpace(request.SearchTitle))
            {
                toDoItems = toDoItems.Where(x => x.Title.Contains(request.SearchTitle));
            }
            if (!string.IsNullOrWhiteSpace(request.SearchDescription))
            {
                toDoItems = toDoItems.Where(x => x.Title.Contains(request.SearchDescription));
            }
            switch (request.DoneStatus)
            {
                case DoneStatus.Pending:
                    toDoItems = toDoItems
                        .Where(x => !x.Done);
                    break;
                case DoneStatus.Done:
                    toDoItems = toDoItems
                        .Where(x => x.Done);
                    break;
                case DoneStatus.All:
                    break;
            }

            toDoItems = toDoItems.OrderByDescending(x => x.Priority);
            var model = new ToDoItemsViewModel
            {
                ToDoItems = _mapper.Map<IEnumerable<ToDoItem>>(await toDoItems.ToListAsync(cancellationToken))
            };
            return model;
        }
    }
}