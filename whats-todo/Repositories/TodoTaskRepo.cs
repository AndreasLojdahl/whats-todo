using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whats_todo.Interfaces;
using whats_todo.Models;

namespace whats_todo.Repositories
{
    public class TodoTaskRepo : ITodoTaskRepo
    {
        public TodoTask GetTodoTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoTask> GetTodoTasks()
        {
            var tasks = new List<TodoTask>
            {
                new TodoTask { Text = "Hi", Day = "2", Reminder = true }
            };

            return tasks;
        }
    }
}
