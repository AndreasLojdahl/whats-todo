using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Models;

namespace whats_todo.Interfaces
{
    public interface ITodoTaskRepo
    {
        Task<bool> SaveChanges();
        IEnumerable<TodoTask> GetTodoTasks();
        TodoTask GetTodoTaskById(int id);

        Task<bool> CreateTodoTask(TodoTask todoTask);
        void UpdateTodoTask(TodoTask todoTask);
        void DeleteTodoTask(TodoTask todoTask);
    }
}
