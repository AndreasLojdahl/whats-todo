using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Interfaces;
using whats_todo.Models;

namespace whats_todo.Services
{
    public class TodoTaskService : ITodoTaskService
    {
        private readonly ITodoTaskRepo _todoTaskRepo;

        public TodoTaskService(ITodoTaskRepo todoTaskRepo)
        {
            _todoTaskRepo = todoTaskRepo;
        }
        public TodoTask GetTodoTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoTask> GetTodoTasks()
        {
            return _todoTaskRepo.GetTodoTasks();
        }
    }
}
