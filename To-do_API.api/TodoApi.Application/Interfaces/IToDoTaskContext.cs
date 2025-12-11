using To_do_API.api.Models;
using To_do_API.api.TodoApi.Application.Interfaces;

namespace TodoApi.Domain.Interfaces;

public interface IToDoTaskContext
{
    
    int Count {get;}
    List<IToDoModel> GetAllToDoModels();
    IToDoModel AddToDoModel(string title, string? description,bool isCompleted,DateTime createdAt, DateTime? dueDate);
}