using To_do_API.api.Models;

namespace TodoApi.Domain.Interfaces;

public interface ICreateTodoRequest
{
    
    int Count {get;}
    List<ICreateTodoRequest> GetAllTasks();
    ICreateTodoRequest AddTask(string title, string description, DateTime dueDate);
}