namespace TodoApi.Application.DTOs; // Namespace for output DTOs

public class TodoResponse // Defines data returned to the client (read-only view)
{
    public int Id { get; set; } 
    // Unique identifier
    
    //::Ikke noe tittel?
    public string Title { get; set; } = ""; 
    // Task title

    public string? Description { get; set; } 
    // Optional details

    public bool IsCompleted { get; set; } 
    // Whether the task is done

    public DateTime CreatedAt { get; set; } 
    // Time task was created

    public DateTime? DueDate { get; set; } 
    // Optional deadline
}