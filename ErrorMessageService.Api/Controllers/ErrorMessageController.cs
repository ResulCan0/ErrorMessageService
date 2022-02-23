using ErrorMessageService.API.Handlers.ErrorMessage.Queries;
using ErrorMessageService.Business.Handlers.ErrorMessage.Commands;
using ErrorMessageService.Business.Handlers.ErrorMessage.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApi.Controllers.BaseController;

namespace ErrorMessageService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorMessageController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return Ok(await Mediator.Send(new GetErrorMessageQuery()));
        }

        [HttpGet("{errorMessageId}")]
        public async Task<IActionResult> GetById(int errorMessageId)
        {
            return Ok(await Mediator.Send(new GetErrorMessageByIdQuery() { ErrorMessageId = errorMessageId }));
        }
        [HttpGet("/LanguageId/{languageId}/StatusCode/{statusCode}")]
        public async Task<IActionResult> GetErrorMessageBySubStatusCode(int languageId,int statusCode)
        {
            return Ok(await Mediator.Send(new GetErrorMessageByStatusCode() {LanguageId  = languageId,StatusCode = statusCode}));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateErrorMessageCommand createCategoryCommand)
        {
            return Created("", await Mediator.Send(createCategoryCommand));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteErrorMessageCommand deleteErrorMessageCommand)
        {
            return Ok(await Mediator.Send(deleteErrorMessageCommand));
        }
    }
}
