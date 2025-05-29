using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ToDo.Domain.Models;

namespace ToDo.Application.Services.Contracts;

public interface IToDoService
{
    Task<IReadOnlyCollection<ToDoes>> GetAll();

    Task<ToDoes> GetById(int id);

    Task CreateTask([FromBody] ToDoes response);

    Task UpdateTask([FromBody] ToDoes response);

    Task DeleteTask(int id);
}
