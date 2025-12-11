//using To_do_API.api.TodoApi.Application.DTOs;

using To_do_API.api.Models;
using To_do_API.api.TodoApi.Application.Interfaces;
using To_do_API.api.TodoApi.Application.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

//adding swagger below
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adding services to the container.

builder.Services.AddSingleton<IToDoModel,ToDoModel>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    //these 2 below are part of swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

/* app.UseHttpsRedirection(); */

app.MapControllers();

app.Run();