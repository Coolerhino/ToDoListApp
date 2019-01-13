using MediatR;

namespace ToDoListApp.Application.ToDoItems.Commands.ToggleDone
{
    public class ToggleDoneCommand : IRequest<bool>
    {
        public int ItemId { get; set; }
    }
}
