using TodoApi.Application.DTOs; // Import DTOs

namespace TodoApi.Application.Services; // Namespace for service layer

public interface ITodoService // Defines business logic operations
{
    Task<IEnumerable<TodoResponse>> GetAllAsync(); 
    // Return all tasks

    Task<TodoResponse?> GetByIdAsync(int id); 
    // Get a single task, or null if not found

    Task<TodoResponse> CreateAsync(CreateTodoRequest request); 
    // Create a new task

    Task<TodoResponse?> UpdateAsync(int id, CreateTodoRequest request); 
    // Update existing task, return null if not found

    Task<bool> DeleteAsync(int id); 
    // Delete a task, return true/false
}
