using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}