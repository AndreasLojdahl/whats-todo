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

        public async void CreateTodoTask(TodoTask todoTask)
        {
           await _todoTaskRepo.CreateTodoTask(todoTask);
        }

        public async Task<bool> UpdateTodoTask(TodoTask todoTask)
        {
           _todoTaskRepo.UpdateTodoTask(todoTask);
            return await _todoTaskRepo.SaveChanges();
        }

        public TodoTask GetTodoTaskById(int id)
        {
            return _todoTaskRepo.GetTodoTaskById(id);
        }

        public IEnumerable<TodoTask> GetTodoTasks()
        {
            return _todoTaskRepo.GetTodoTasks();
        }

        public async Task<bool> DeleteTodoTask(TodoTask todoTask)
        {
            _todoTaskRepo.DeleteTodoTask(todoTask);
            return await _todoTaskRepo.SaveChanges();
        }
    }
}
