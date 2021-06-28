using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Dtos;
using whats_todo.Interfaces;
using whats_todo.Models;

namespace whats_todo.Controllers
{
    [Route("api/todotasks")]
    [ApiController]
    public class TodoTaskController : Controller
    {
  
        private readonly ITodoTaskService _todoTaskService;
        private readonly IMapper _mapper;

        public TodoTaskController(ITodoTaskService todoTaskService, IMapper mapper)
        {
            _todoTaskService = todoTaskService;
            _mapper = mapper;
        }
        /// <summary> Gets all TodoTasks </summary>
        /// <returns> A list of TodoTasks </returns>
        /// <response code="200">Returns a list of TodoTasks</response>
        [HttpGet(Name = "GetTodoTasks")]
        public ActionResult<IEnumerable<TodoTaskReadDto>> GetTodoTasks()
        {
            var todoTasks = _todoTaskService.GetTodoTasks();
            return Ok(_mapper.Map<IEnumerable<TodoTaskReadDto>>(todoTasks));
        }

        /// <summary> Gets a specific TodoTask by an id </summary>
        /// <returns>A todoTaskReadDto from a specific id </returns>
        /// <response code="200">Returns a specific TodoTasks</response>
        [HttpGet("{id}", Name ="GetTodoTaskById")]
        public ActionResult<TodoTaskReadDto> GetTodoTaskById(int id)
        {
            var todoTasks = _todoTaskService.GetTodoTaskById(id);
            if(todoTasks != null)
            {
                return Ok(_mapper.Map<TodoTaskReadDto>(todoTasks));
            }
            return NotFound();
        }
        
        /// <summary> Creates a TodoTask </summary>
        /// <returns> Returns a created TodoTask  </returns>
        /// <response code="201">Returns a created TodoTasks</response>
        [HttpPost(Name = "CreateTodoTasks")]
        public ActionResult<TodoTaskReadDto> CreateTodoTasks([FromBody] TodoTaskCreateDto todoTask)
        {   
            var newTodoTask = _mapper.Map<TodoTask>(todoTask);
            _todoTaskService.CreateTodoTask(newTodoTask);

            var readTodoTask = _mapper.Map<TodoTaskReadDto>(newTodoTask);
            return CreatedAtRoute(nameof(GetTodoTaskById), new { Id = readTodoTask.Id }, readTodoTask);
        }

        /// <summary> Updates a TodoTask </summary>
        /// <response code="204">If a company user is successfully updated</response>
        ///   /// <response code="404">If unable to find company user</response>
        ///    /// <response code="400">If params are invalid</response>
        [HttpPut("{id}",Name = "UpdateTodoTasks")]
        public async Task<ActionResult> UpdateTodoTasks(int id, [FromBody] TodoTaskUpdateDto todoTaskUpdate)
        {
            var todoTaskFromDb = _todoTaskService.GetTodoTaskById(id);
            if(todoTaskFromDb == null)
            {
                return NotFound();
            }

            _mapper.Map(todoTaskUpdate, todoTaskFromDb);

            var isSucces = await _todoTaskService.UpdateTodoTask(todoTaskFromDb);
            
            if (isSucces)
            {
                return NoContent();
            }
            return BadRequest("Couldn't Update Task");

        }

        /// <summary> Deletes a TodoTask </summary>
        [HttpDelete("{id}", Name = "DeleteTodoTasks")]
        public async Task<ActionResult> DeleteTodoTasks(int id)
        {
            var todoTaskFromDb = _todoTaskService.GetTodoTaskById(id);
            if (todoTaskFromDb == null)
            {
                return NotFound();
            }
            var isSuccess = await _todoTaskService.DeleteTodoTask(todoTaskFromDb);
            if (isSuccess)
            {
                return NoContent();
            }
            return BadRequest("Couldn't Delete Task");
        }
    }
}
