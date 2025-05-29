using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Services.Contracts;
using ToDo.Domain.Models;

namespace ToDo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoesController : ControllerBase
    {
        private readonly IToDoService _toDoService;
        public ToDoesController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _toDoService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _toDoService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ToDoes toDoes)
        {
            await _toDoService.CreateTask(toDoes);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ToDoes toDoes)
        {
            await _toDoService.UpdateTask(toDoes);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _toDoService.DeleteTask(id);
            return Ok();
        }
        // повертати модельки контролерів
    }
}
