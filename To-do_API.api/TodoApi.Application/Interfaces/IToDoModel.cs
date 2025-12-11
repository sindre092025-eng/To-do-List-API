namespace To_do_API.api.TodoApi.Application.Interfaces;

public interface IToDoModel
{
    int Id {get;init;}
    string Title {get;set;}
    string? Description {get;set;}
    bool IsCompleted {get;set;}
    DateTime DueDate {get;set;}
    void MarkAsCompleted();
}