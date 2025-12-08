namespace TodoApi.Domain.Entities
{
    // This class represents a single To-Do item in the system.
    public class TodoItem
    {
        public int Id { get; set; }// Unique identifier for the item (primary key).

        public string Title { get; set; } = string.Empty;// Short name of the task. Never null because of = string.Empty.

        public string? Description { get; set; }// Optional longer text about the task. The ? allows null values.

        public bool IsCompleted { get; set; }// True if the task is finished, false otherwise.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;// Automatically sets the creation time when the item is made.

        public DateTime? DueDate { get; set; }// Optional deadline for the task. Null means "no deadline".
    }
}