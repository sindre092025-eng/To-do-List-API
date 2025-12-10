using System;
using To_do_API.api.TodoApi.Domain.Enums;

namespace To_do_API.api.Models;

public class ErrorHandling
{
    public ErrorCode PreformOpreation(string inputdata)
    {
        if(string.IsNullOrEmpty(inputdata))
        {
            return ErrorCode.BadRequest;
        }
        
        if()
        {
            return ErrorCode.Unauthorized;
        }
    }
}
