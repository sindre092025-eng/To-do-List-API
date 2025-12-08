using TodoApi.Domain.Entities; // Importing the TodoItem class so the interface can use it

namespace TodoApi.Domain.Interfaces; // Namespace for repository interfaces

public interface ITodoRepository // Defines a contract for how data storage must behave
{
    Task<List<TodoItem>> GetAllAsync(); 
    // Asynchronously returns all TodoItem objects in the storage.

    Task<TodoItem?> GetByIdAsync(int id); 
    // Returns the TodoItem with matching ID. 
    // If not found → returns null.

    Task<TodoItem> AddAsync(TodoItem item); 
    // Adds a new TodoItem to the storage and returns it (with ID set).

    Task<TodoItem?> UpdateAsync(TodoItem item); 
    // Updates an existing TodoItem.
    // Returns null if the item does not exist.

    Task<bool> DeleteAsync(int id); 
    // Deletes the TodoItem with the given ID.
    // Returns true if deleted successfully, false if not found.
    }