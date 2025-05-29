using ToDo.Domain.Enums;

namespace ToDo.API.Models
{
    public class ToDoResponse
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public ToDoStatus Status { get; set; }
    }
}
