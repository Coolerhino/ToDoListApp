using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp.Application.ToDoItems.Commands.AddToDoItem;
using ToDoListApp.Application.ToDoItems.Commands.DeleteToDoItem;
using ToDoListApp.Application.ToDoItems.Queries;
using ToDoListApp.Domain.Entities;

namespace ToDoListApp.Controllers
{
    public class ToDoListController : BaseMediatrController
    {
        [HttpGet]
        public async Task<IActionResult> Items()
        {
            var items = await Mediator.Send(new GetAllToDoItemsQuery());
                //var vm = new ToDoItemViewModel{ToDoItems = items};
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
            //w ogole zrob brzydko podstawowa funkcjonalnosc i potem taski stad przerzucaj tam
            //todo return form view for creating
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateToDoItemCommand command)
        {
            await Mediator.Send(command);
            return View();
        }
    }
}