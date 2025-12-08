using System;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace To_do_API.api.Models;

public class ToDoModel(string title, string tasks, DateTime deadline, bool completion = false)
{
    public  Guid Id { get; set; } = Guid.NewGuid();

    public string Title {get;set;} = title;

    public string Tasks {get;set;} = tasks;

    public DateTime Deadline {get;set;} = deadline;

    public bool Completion {get;set;} = completion;

}
