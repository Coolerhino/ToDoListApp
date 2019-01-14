using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp.Application.ToDoItems.Commands.AddToDoItem;
using ToDoListApp.Application.ToDoItems.Commands.DeleteToDoItem;
using ToDoListApp.Application.ToDoItems.Commands.ToggleDone;
using ToDoListApp.Application.ToDoItems.Commands.UpdateToDoItem;
using ToDoListApp.Application.ToDoItems.Queries;
using ToDoListApp.Application.ToDoItems.Queries.GetToDoItem;
using ToDoListApp.Domain.Entities;
using X.PagedList;

namespace ToDoListApp.Controllers
{
    public class ToDoListController : BaseMediatrController
    {

        public async Task<IActionResult> Items(int page = 1)
        {
            var items = await Mediator.Send(new GetAllToDoItemsQuery());
            var pagedItems = items.ToDoItems.ToPagedList(page, 6);
            ViewBag.ItemsPage = pagedItems;
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> Items(GetAllToDoItemsQuery query, int page = 1)
        {
            var items = await Mediator.Send(query);
            var pagedItems = items.ToDoItems.ToPagedList(page, 6);
            ViewBag.ItemsPage = pagedItems;
            return View(items);
        }

        /*        [HttpGet]
                public async Task<IActionResult> Item(int itemId)
                {
                    var item = await Mediator.Send(new GetToDoItemQuery { ToDoItemId = itemId });
                    return View(item);
                }*/

        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteToDoItemCommand { Id = id });
            return View("Items", await Mediator.Send(new GetAllToDoItemsQuery()));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateToDoItemCommand command)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(command);
                return View("Items");
            }

            return View("Create", command);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var toDoItem = await Mediator.Send(new GetToDoItemQuery { ToDoItemId = id });
            return View(toDoItem);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ToDoItem item)
        {
            item.ToDoItemId = id;
            await Mediator.Send(new UpdateToDoItemCommand { ToDoItem = item });
            return View("Items", await Mediator.Send(new GetAllToDoItemsQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> ToggleDone(int id)
        {
            var newStatus = await Mediator.Send(new ToggleDoneCommand {ItemId = id});
            return Ok(newStatus);
        }
    }
}