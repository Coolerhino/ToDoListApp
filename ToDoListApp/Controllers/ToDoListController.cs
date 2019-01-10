using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp.Application.ToDoItems.Queries;

namespace ToDoListApp.Controllers
{
    public class ToDoListController : BaseMediatrController
    {
        [HttpGet]
        public async Task<ActionResult<ToDoItemViewModel>> Items()
        {
            return View(await Mediator.Send(new GetAllToDoItemsQuery()));
        }
    }
}