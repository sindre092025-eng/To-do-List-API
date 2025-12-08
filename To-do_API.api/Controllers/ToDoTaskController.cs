using Microsoft.AspNetCore.Mvc;

namespace To_do_API.api.Controllers;


[ApiController]

[Route("/[Controller]")]

public class ToDoTaskController(ITaskContext context, ILogger<ToDoTaskController> logger) : ControllerBase

{

    [HttpGet]

    public IActionResult Get([FromQuery] QueryDto queryDto) 

    {

        try 

        {

            return Ok(queryDto.BuildQuery(context));

        }

        catch (Exception ex)

        {

            logger.LogError(ex.Message);

            return StatusCode(500, ex.Message);

        }

    }

    

    // Flere metoder for andre operasjoner...

}