using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp.Application.ToDoItems.Commands.AddToDoItem;
using ToDoListApp.Application.ToDoItems.Commands.DeleteToDoItem;
using ToDoListApp.Application.ToDoItems.Commands.UpdateToDoItem;
using ToDoListApp.Application.ToDoItems.Queries;
using ToDoListApp.Application.ToDoItems.Queries.GetToDoItem;
using ToDoListApp.Domain.Entities;

namespace ToDoListApp.Controllers
{
    public class ToDoListController : BaseMediatrController
    {
        [HttpGet]
        public async Task<IActionResult> Items()
        {
            var items = await Mediator.Send(new GetAllToDoItemsQuery());
                //var vm = new ToDoItemsViewModel{ToDoItems = items};
            return View(items);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteToDoItemCommand {Id = id});
            return Ok();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateToDoItemCommand command)
        {
            await Mediator.Send(command);
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var toDoItem = await Mediator.Send(new GetToDoItemQuery {ToDoItemId = id});
            return View(toDoItem);
        }
        [HttpPut]
        public async Task<IActionResult> Edit(ToDoItem item)
        {
            await Mediator.Send(new UpdateToDoItemCommand{ToDoItem = item});
            return View();
        }
    }
}