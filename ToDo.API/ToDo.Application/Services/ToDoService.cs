using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Services.Contracts;
using ToDo.Domain;
using ToDo.Domain.Models;

namespace ToDo.Application.Services
{
    public class ToDoService : IToDoService
    {
        private readonly Data _data;
        public ToDoService(Data data)
        {
             _data = data;
        }
        public Task CreateTask([FromBody] ToDoes response)
        {
            var newToDo = new ToDoes()
            {
                Id = response.Id,
                Title = response.Title,
                Description = response.Description,
                Status = response.Status,
            };
            _data.ToDoes.Add(newToDo);
            return Task.CompletedTask;
        }

        public Task DeleteTask(int id)
        {
            var toDo = _data.ToDoes.FirstOrDefault(x => x.Id == id);
            _data.ToDoes.Remove(toDo);
            return Task.CompletedTask;
        }

        public async Task<IReadOnlyCollection<ToDoes>> GetAll()
        {
            return _data.ToDoes.ToList();
        }

        public  Task<ToDoes> GetById(int id)
        {
            var toDo = _data.ToDoes.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(toDo);
        }

        public Task UpdateTask([FromBody] ToDoes response)
        {
            var toDo = _data.ToDoes.FirstOrDefault(x => x.Id == response.Id);
            toDo.Title = response.Title;
            toDo.Description = response.Description;    
            toDo.Status = response.Status;
            return Task.CompletedTask;
        }
    }
}
