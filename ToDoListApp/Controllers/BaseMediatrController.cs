using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoListApp.Controllers
{
    public abstract class BaseMediatrController : Controller
    {
        private IMediator _mediator;
        public IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}