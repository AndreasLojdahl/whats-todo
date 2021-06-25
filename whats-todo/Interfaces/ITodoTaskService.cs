using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Models;

namespace whats_todo.Interfaces
{
    public interface ITodoTaskService
    {
        IEnumerable<TodoTask> GetTodoTasks();
        TodoTask GetTodoTaskById(int id);

        void CreateTodoTask(TodoTask todoTask);

        Task<bool> UpdateTodoTask(TodoTask todoTask);

        Task<bool> DeleteTodoTask(TodoTask todoTask);
        
    }
}
