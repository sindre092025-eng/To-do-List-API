using System;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace To_do_API.api.Models;

public class ToDoModel(string title, string description, bool completion, DateTime deadline)
{
    public string? Title {get;set;} = title;
    public string? Description {get;set;} = description;
    public bool Completion {get;set;} = completion;
    public DateTime Deadline {get;set;} = deadline;
    public TodoStatus Status { get; set; } = TodoStatus.Pending;// Property that stores the todo's status, which has default as "Pending" when a new TodoItem is created
}
