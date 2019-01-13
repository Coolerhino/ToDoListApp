using MediatR;

namespace ToDoListApp.Application.ToDoItems.Queries
{
    public class GetAllToDoItemsQuery : IRequest<ToDoItemsViewModel>
    {
        public string SearchTitle { get; set; }
        public string SearchDescription { get; set; }
        public string SortOrder { get; set; }
        public DoneStatus DoneStatus { get; set; }
    }
}