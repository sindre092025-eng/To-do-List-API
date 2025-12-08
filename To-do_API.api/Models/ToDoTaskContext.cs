using To_do_API.api.TodoApi.Application.Interfaces;
using TodoApi.Domain.Interfaces;

namespace To_do_API.api.Models;

public class ToDoTaskContext : IToDoTaskContext
{
    private List<IToDoModel> _tasks = [];
    private int _nextId;
    public int Count => _tasks.Count;
    public List<IToDoModel> GetAllToDoModels()
    {
        return _tasks;
    }

    public IToDoModel AddToDoModel(int id, string title, string? description, bool isCompleted, DateTime createdAt, DateTime? dueDate)
    {
        var toDoModel = new ToDoModel(++_nextId, title, description, createdAt, dueDate, isCompleted);
        _tasks.Add(toDoModel);
        return toDoModel;
    }
}