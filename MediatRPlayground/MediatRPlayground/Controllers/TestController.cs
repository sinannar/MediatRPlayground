using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatRPlayground.Controllers;
[ApiController]
[Route("api/[controller]/[action]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> logger;
    public IMediator mediator;

    public TestController(ILogger<TestController> logger, 
        IMediator mediator)
    {
        this.logger = logger;
        this.mediator = mediator;
    }

    [HttpPost]
    public async Task<string> Test(string message)
    {
        return await mediator.Send(new StringRequest { message = message});
    }
}
