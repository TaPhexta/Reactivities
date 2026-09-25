using Microsoft.AspNetCore.Mvc;
using Domain;
using MediatR;
using Application.Activities.Queries;
using Application.Activities.Commands;

namespace API.Controllers;

public class ActivitiesController(IMediator mediator) : BaseApiController
{

    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await mediator.Send(new GetActivityList.Query());
    } 

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(string id)
    {
        return await mediator.Send(new GetActivityDetails.Query { Id = id });
    }

    [HttpPost]
    public async Task<ActionResult<string>> CreateActivity(Activity activity)
    {
        return await mediator.Send(new CreateActivity.Command { Activity = activity });
    }

    [HttpPut]
    public async Task<ActionResult> EditActivity(Activity activity)
    {
        await mediator.Send(new EditActivity.Command { Activity = activity });
        return NoContent();
    }

    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteActivity(string id)
    {
        await mediator.Send(new DeleteActivity.Command{Id = id});
        return Ok();
    }

}
