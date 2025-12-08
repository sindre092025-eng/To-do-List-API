using To_do_API.api.Models;
using To_do_API.api.TodoApi.Application.Interfaces;

namespace TodoApi.Domain.Interfaces;

public interface IToDoTaskContext
{
    
    int Count {get;}
    List<IToDoModel> GetAllTasks();
    IToDoModel AddTask(string title, string description, DateTime dueDate);
}