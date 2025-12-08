using TodoApi.Domain.Entities;//this bit imports the TodoItem class so it can be used in the interface.

namespace TodoApi.Domain.Interfaces
{
    // Defines a contract for how a Todo repository must behave.
    public interface ITodoRepository
    {
        Task<List<TodoItem>> GetAllAsync();// this retrieves all todo items from the data store.

        Task<TodoItem?> GetByIdAsync(int id);// this oune retrieves a single todo item by its ID, incase no item with that ID exists it return NULL.

        Task<TodoItem> AddAsync(TodoItem item);// it adds a new todo item to the data store, it also returns the item after it has been saved.

        Task<TodoItem?> UpdateAsync(TodoItem item);// it updates an existing todo item, returns the updated item, or returns a null if the item did not exist.

        Task<bool> DeleteAsync(int id);// this bit deletes a todo item by ID and returns true if successfully deleted, or false if not found.
    }
}