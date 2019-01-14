using System;
using FluentValidation;
using ToDoListApp.Domain.Enums;

namespace ToDoListApp.Application.ToDoItems.Commands.AddToDoItem
{
    public class CreateToDoItemCommandValidator : AbstractValidator<CreateToDoItemCommand>
    {
        public CreateToDoItemCommandValidator()
        {
            RuleFor(x => x.Title).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Priority).IsInEnum();
            RuleFor(x => x.Description).MaximumLength(200);
            RuleFor(x => x.EstimatedFinish).GreaterThan(DateTime.Now);
        }
    }
}