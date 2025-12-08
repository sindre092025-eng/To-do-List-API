using To_do_API.api.TodoApi.Application.Interfaces;
using TodoApi.Domain.Interfaces;

namespace To_do_API.api.Models;

public class ToDoTaskContext : IToDoTaskContext
{
    private List<IToDoModel> _tasks = [];
    public int Count => _tasks.Count;
    public List<IToDoModel> GetAllTasks()
    {
        return _tasks;
    }

    public IToDoModel AddTask(string title, string description, DateTime dueDate)
    {
        throw new NotImplementedException();
    }
}