using To_do_API.api.TodoApi.Application.Interfaces;

namespace To_do_API.api.Models
{
    // so this class is a domain entity that describes a single to-do item in your system.It contains all the data your API needs for one task.
    public class ToDoModel : IToDoModel
    {
        public int Id { get; set; }// Unique identifier for the item (primary key).

        public string Title { get; set; } = string.Empty;// Short name of the task. Never null because of = string.Empty.

        public string? Description { get; set; }// Optional longer text about the task. The ? allows null values.

        public bool IsCompleted { get; set; }// True if the task is finished, false otherwise.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;// Automatically sets the creation time when the item is made.

        public DateTime? DueDate { get; set; }// Optional deadline for the task. Null means "no deadline".

        
    }
}