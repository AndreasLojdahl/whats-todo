using AutoMapper;
using whats_todo.Dtos;
using whats_todo.Models;

namespace whats_todo.Profiles
{
    public class TodotaskProfile: Profile
    {
        public TodotaskProfile()
        {
            CreateMap<TodoTask, TodoTaskReadDto>();
            CreateMap<TodoTaskCreateDto, TodoTask>();
            CreateMap<TodoTaskUpdateDto, TodoTask>();
        }
    }
}
