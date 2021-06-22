using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Interfaces;
using whats_todo.Models;

namespace whats_todo.Controllers
{
    [Route("todotasks")]
    [ApiController]
    public class TodoTaskController : Controller
    {
        private readonly ITodoTaskRepo _todoTaskRepo;

        public TodoTaskController(ITodoTaskRepo todoTaskRepo)
        {
            _todoTaskRepo = todoTaskRepo;
        }
        /// <summary> Gets all TodoTasks </summary>
        /// <returns> A list of TodoTasks </returns>
        /// <response code="200">Returns a list of TodoTasks</response>
        [HttpGet(Name = "GetTodoTasks")]
        public IEnumerable<TodoTask> GetTodoTasks()
        {
            return _todoTaskRepo.GetTodoTasks();
        }
    }
}
