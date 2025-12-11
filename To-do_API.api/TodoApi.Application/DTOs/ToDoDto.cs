using System;
using To_do_API.api.TodoApi.Application.Interfaces;
using TodoApi.Domain.Interfaces;
using To_do_API.api.Models;
using System.Text.Json.Serialization;

namespace To_do_API.api.TodoApi.Application.DTOs;

public class ToDoDto
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    [JsonPropertyName("DueDate")]
    public DateTime DueDate { get; set; }

    public IToDoModel InsertTask(IToDoTaskContext context)
    {
        return IToDoTaskContext.AddToDoModel(title, string? description,bool isCompleted,DateTime createdAt, DateTime? dueDate);
    }
}
