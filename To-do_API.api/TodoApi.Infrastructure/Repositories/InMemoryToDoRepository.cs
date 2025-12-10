using TodoApi.Domain.Entities;     // Import the TodoItem class
using TodoApi.Domain.Interfaces;   // Import the ITodoRepository interface

namespace TodoApi.Infrastructure.Repositories; // Namespace for data access implementations

public class InMemoryTodoRepository : ITodoRepository // Stores todos in RAM for simplicity
{
    //::Readonly?
    private readonly List<TodoItem> _items = new(); 
    // In-memory list that behaves like a fake database

    public Task<List<TodoItem>> GetAllAsync() =>
        Task.FromResult(_items); 
    // Returns the entire list of tasks

    public Task<TodoItem?> GetByIdAsync(int id) =>
        Task.FromResult(_items.FirstOrDefault(x => x.Id == id)); 
    // Finds a task with matching ID or returns null

    public Task<TodoItem> AddAsync(TodoItem item)
    {
        // Create a new incremental ID (1, 2, 3, ...)
        item.Id = _items.Count == 0 ? 1 : _items.Max(x => x.Id) + 1;

        _items.Add(item); // Add new item to the list
        return Task.FromResult(item); // Return the created item
    }

    public Task<TodoItem?> UpdateAsync(TodoItem item)
    {
        // Look for the existing item
        var existing = _items.FirstOrDefault(x => x.Id == item.Id);
        if (existing == null) return Task.FromResult<TodoItem?>(null);

        // Update fields
        existing.Title = item.Title;
        existing.Description = item.Description;
        existing.IsCompleted = item.IsCompleted;
        existing.DueDate = item.DueDate;

        //::Legg inn det som skjer når existing er nullifisert.
        return Task.FromResult(existing); // Return updated item
    }

    public Task<bool> DeleteAsync(int id)
    {
        // Look for the item
        var existing = _items.FirstOrDefault(x => x.Id == id);

        if (existing == null) 
            return Task.FromResult(false); // No item found

        _items.Remove(existing); // Remove from list
        return Task.FromResult(true); // Deletion successful
    }
}
