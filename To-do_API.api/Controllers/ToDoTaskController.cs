using Microsoft.AspNetCore.Mvc;
using TodoApi.Domain.Interfaces;

namespace To_do_API.api.Controllers;


[ApiController]

[Route("/[Controller]")]

public class ToDoTaskController(IToDoTaskContext taskContext, ILogger<ToDoTaskController> logger) : ControllerBase

{

    [HttpGet]

    public IActionResult Get([FromQuery] QueryDto queryDto) 

    {

        try 

        {

            return Ok(queryDto.BuildQuery(taskContext));

        }

        catch (Exception ex)

        {

            logger.LogError(ex.Message);

            return StatusCode(500, ex.Message);

        }

    }

    

    

}