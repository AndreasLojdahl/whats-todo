using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Models;

namespace whats_todo.Interfaces
{
    interface ITodoTaskService
    {
        IEnumerable<TodoTask> GetTodoTasks();
        TodoTask GetTodoTaskById(int id);
    }
}
