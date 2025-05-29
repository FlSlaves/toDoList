
using ToDo.Domain.Enums;
using ToDo.Domain.Models;

namespace ToDo.Domain
{
    public class Data
    {
        public List<ToDoes> ToDoes = new List<ToDoes>
        {
            new ToDoes { Id = 1, Title = "Title 1", Description = "Description 1", Status = ToDoStatus.Done },
            new ToDoes { Id = 2, Title = "Title 2", Description = "Description 2", Status = ToDoStatus.InProgress },
            new ToDoes { Id = 3, Title = "Title 3", Description = "Description 3", Status = ToDoStatus.ToDo },
            new ToDoes { Id = 4, Title = "Title 4", Description = "Description 4", Status = ToDoStatus.InProgress },
            new ToDoes { Id = 5, Title = "Title 5", Description = "Description 5", Status = ToDoStatus.Undefined },
            new ToDoes { Id = 6, Title = "Title 6", Description = "Description 6", Status = ToDoStatus.InProgress },
            new ToDoes { Id = 7, Title = "Title 7", Description = "Description 7", Status = ToDoStatus.Done },
            new ToDoes { Id = 8, Title = "Title 8", Description = "Description 8", Status = ToDoStatus.InProgress },
            new ToDoes { Id = 9, Title = "Title 9", Description = "Description 9", Status = ToDoStatus.InProgress },
            new ToDoes { Id = 10, Title = "Title 10", Description = "Description 10", Status = ToDoStatus.ToDo }
        };
    }
}
