using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace whats_todo.Models
{
    public class TodoTask
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // [Required]
        public string Text { get; set; }
        //Required
        public string Day { get; set; }
        //Required
        public bool Reminder { get; set; }
    }
}
