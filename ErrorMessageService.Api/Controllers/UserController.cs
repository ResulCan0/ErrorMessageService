using ErrorMessageService.Business.Handlers.Users.Commands;
using ErrorMessageService.Business.Handlers.Users.Queries;
using ErrorMessageService.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApi.Controllers.BaseController;

namespace ErrorMessageService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        [HttpGet("/GetUsers")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await Mediator.Send(new GetUserQuery()));
        }

        [HttpPost("/SaveUser")]
        public async Task<IActionResult> Add([FromBody] CreateUserCommand createUserCommand)
        {
                return Created("", await Mediator.Send(createUserCommand));
        }
    }
}
