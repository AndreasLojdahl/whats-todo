using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Context;
using whats_todo.Interfaces;
using whats_todo.Models;

namespace whats_todo.Repositories
{
    public class TodoTaskRepo : ITodoTaskRepo
    {
        private readonly TaskContext _context;

        public TodoTaskRepo(TaskContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateTodoTask(TodoTask todoTask)
        {
            if(todoTask == null)
            {
                throw new ArgumentNullException(nameof(todoTask));
            }

            _context.TodoTasks.Add(todoTask);
            return await SaveChanges();
            
        }

        public void DeleteTodoTask(TodoTask todoTask)
        {
            _context.Remove<TodoTask>(todoTask);
        }

        public TodoTask GetTodoTaskById(int id)
        {
            return _context.TodoTasks.FirstOrDefault(task => task.Id == id);
        }

        public IEnumerable<TodoTask> GetTodoTasks()
        {
            return _context.TodoTasks.ToList();
        }

        public async Task<bool> SaveChanges()
        {
            var response = await _context.SaveChangesAsync();
            return response >= 0;
        }

        public void UpdateTodoTask(TodoTask todoTask)
        {
            _context.Update<TodoTask>(todoTask);  
        }

       
    }
}
