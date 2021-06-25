using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using whats_todo.Models;

namespace whats_todo.Context
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> opt) : base(opt)
        {

        }

        public DbSet<TodoTask> TodoTasks { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlite($@"Data Source = {OnConfiguring.}")
        
    }
}
