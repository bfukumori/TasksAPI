using Microsoft.AspNetCore.Mvc;
using Tasks.Application.UseCases.Tasks.Create;
using Tasks.Application.UseCases.Tasks.Delete;
using Tasks.Application.UseCases.Tasks.Read;
using Tasks.Application.UseCases.Tasks.Update;
using Tasks.Communication.Requests;
using Tasks.Communication.Responses;

namespace Tasks.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Tasks : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult RegisterTask([FromBody] RequestTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseShortTaskJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAllTasks()
    {
        var response = new GetAllTasksUseCase().Execute();

        if (response.Tasks.Count != 0)
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetTaskById([FromRoute] int id)
    {
        var response = new GetTaskByIdUseCase().Execute(id);

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult UpdateTask([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        new UpdateTaskUseCase().Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult DeleteTask([FromRoute] int id)
    {
        new DeleteTaskUseCase().Execute(id);

        return NoContent();
    }
}
