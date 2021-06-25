using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace whats_todo.Dtos
{
    public class TodoTaskUpdateDto
    {
        public string Text { get; set; }
        public string Day { get; set; }
        public bool Reminder { get; set; }
    }
}
