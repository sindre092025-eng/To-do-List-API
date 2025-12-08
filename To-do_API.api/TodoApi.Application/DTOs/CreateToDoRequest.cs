namespace TodoApi.Application.DTOs; // Namespace for input DTOs

public class CreateTodoRequest // Represents input data from client when creating or updating a task
{
    public string Title { get; set; } = ""; 
    // Required title of the task (cannot be null)

    public string? Description { get; set; } 
    // Optional extra text

    public DateTime? DueDate { get; set; } 
    // Optional deadline for completion
}
