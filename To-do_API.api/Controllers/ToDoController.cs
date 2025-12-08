using Microsoft.AspNetCore.Mvc;        // MVC attributes and base classes
using TodoApi.Application.DTOs;        // DTOs for input/output
using TodoApi.Application.Services;    // Service layer interface

namespace TodoApi.Api.Controllers; // Namespace for API controllers

[ApiController] 
// Tells ASP.NET this is a controller that handles HTTP requests

[Route("api/[controller]")]
// Creates route: api/todo

public class TodoController : ControllerBase // Base class containing helper methods like Ok(), NotFound()
{
    private readonly ITodoService _service; 
    // Service layer injected via dependency injection

    public TodoController(ITodoService service)
    {
        _service = service; // Store instance for use in endpoints
    }

    [HttpGet]
    // Handles: GET api/todo
    public async Task<ActionResult<IEnumerable<TodoResponse>>> GetAll()
    {
        return Ok(await _service.GetAllAsync()); 
        // Return all tasks with 200 OK
    }

    [HttpGet("{id:int}")]
    // Handles: GET api/todo/5 (id must be an integer)
    public async Task<ActionResult<TodoResponse>> GetById(int id)
    {
        var item = await _service.GetByIdAsync(id);

        return item == null ? NotFound() : Ok(item); 
        // Return 404 if not found, else return item
    }

    [HttpPost]
    // Handles: POST api/todo
    public async Task<ActionResult<TodoResponse>> Create([FromBody] CreateTodoRequest request)
    {
        var created = await _service.CreateAsync(request); 
        // Create new todo using service layer

        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        // Returns HTTP 201 Created + location header
    }

    [HttpPut("{id:int}")]
    // Handles: PUT api/todo/5
    public async Task<ActionResult<TodoResponse>> Update(int id, [FromBody] CreateTodoRequest request)
    {
        var updated = await _service.UpdateAsync(id, request); 
        // Update the item

        return updated == null ? NotFound() : Ok(updated); 
        // 404 if item missing, else return updated version
    }

    [HttpDelete("{id:int}")]
    // Handles: DELETE api/todo/5
    public async Task<IActionResult> Delete(int id)
    {
        return await _service.DeleteAsync(id) ? NoContent() : NotFound();
        // If deleted → return 204, else 404
    }
}
