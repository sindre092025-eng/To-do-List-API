using TodoApi.Application.DTOs;     // Import DTOs
using TodoApi.Domain.Entities;      // Import domain entity
using TodoApi.Domain.Interfaces;    // Import repository interface

namespace TodoApi.Application.Services; // Namespace for services

public class TodoService : ITodoService // Implements business logic
{
    private readonly ITodoRepository _repository; 
    // Repository injected via constructor (Dependency Injection)

    public TodoService(ITodoRepository repository)
    {
        _repository = repository; // Store repository instance
    }

    public async Task<IEnumerable<TodoResponse>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync(); 
        // Get all tasks from repository

        return items.Select(MapToResponse); 
        // Convert domain entity → Response DTO
    }

    public async Task<TodoResponse?> GetByIdAsync(int id)
    {
        var item = await _repository.GetByIdAsync(id); 
        // Look up item by ID

        return item == null ? null : MapToResponse(item); 
        // If found, map to DTO; otherwise return null
    }

    public async Task<TodoResponse> CreateAsync(CreateTodoRequest request)
    {
        // Convert request DTO → domain entity
        var newItem = new TodoItem
        {
            Title = request.Title,
            Description = request.Description,
            DueDate = request.DueDate,
            CreatedAt = DateTime.UtcNow
        };

        var created = await _repository.AddAsync(newItem); 
        // Save item in repository

        return MapToResponse(created); 
        // Return DTO for client
    }

    public async Task<TodoResponse?> UpdateAsync(int id, CreateTodoRequest request)
    {
        var existing = await _repository.GetByIdAsync(id); 
        // Check if item exists

        if (existing == null) return null; // Not found

        // Update editable fields
        existing.Title = request.Title;
        existing.Description = request.Description;
        existing.DueDate = request.DueDate;

        var updated = await _repository.UpdateAsync(existing); 
        // Save changes

        return updated == null ? null : MapToResponse(updated); 
        // Convert to DTO
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id); 
        // Delete task by ID
    }

    // Helper method to map domain objects to DTOs
    private TodoResponse MapToResponse(TodoItem item)
    {
        return new TodoResponse
        {
            Id = item.Id,
            Title = item.Title,
            Description = item.Description,
            IsCompleted = item.IsCompleted,
            CreatedAt = item.CreatedAt,
            DueDate = item.DueDate
        };
    }
}
