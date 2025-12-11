using To_do_API.api.TodoApi.Application.Interfaces;

namespace To_do_API.api.Models;
    // so this class is a domain entity that describes a single to-do item in your system.It contains all the data your API needs for one task.
    public class ToDoModel (int id, string title, string description, DateTime createdAt, DateTime dueDate, bool isCompleted) : IToDoModel
    {
        public int Id { get; init; } = id;// Unique identifier for the item (primary key).

        public string Title { get; set; } = title;// Short name of the task. Never null because of = string.Empty.

        public string? Description { get; set; } =description;// Optional longer text about the task. The ? allows null values.

        public bool IsCompleted { get; set; } = isCompleted;// True if the task is finished, false otherwise.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;// Automatically sets the creation time when the item is made.

        public DateTime? DueDate { get; set; } = dueDate; // Optional deadline for the task. Null means "no deadline".
    DateTime IToDoModel.DueDate { get => throw new NotImplementedException(); set => DueDate = value; }

    public void MarkAsCompleted()
    {
        throw new NotImplementedException();
    }
}
