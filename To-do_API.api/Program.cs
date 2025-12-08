using TodoApi.Application.Services;      // Import service layer
using TodoApi.Domain.Interfaces;         // Import repository interface
using TodoApi.Infrastructure.Repositories; // Import repository implementation

var builder = WebApplication.CreateBuilder(args);
// Creates the app builder (reads config, sets up hosting, DI container, etc.)

builder.Services.AddControllers();
// Registers controllers so the app can route HTTP requests

builder.Services.AddEndpointsApiExplorer();
// Enables minimal API descriptions for Swagger

builder.Services.AddSwaggerGen();
// Adds automatic Swagger documentation

builder.Services.AddSingleton<ITodoRepository, InMemoryTodoRepository>();
// Register repository (Stored in memory, same instance for whole app)

builder.Services.AddScoped<ITodoService, TodoService>();
// Register service layer (new instance created per HTTP request)

var app = builder.Build();
// Build the actual web application

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
// Tell ASP.NET to map controller endpoints (routes)

app.Run();
// Start the web server
