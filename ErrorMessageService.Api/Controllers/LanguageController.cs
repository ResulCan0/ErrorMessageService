using ErrorMessageService.Business.Handlers.ErrorMessage.Queries;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApi.Controllers.BaseController;

namespace ErrorMessageService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : BaseApiController
    {
        [HttpGet("/LanguageId/{languagePath}/Ps/{pageSize}/Pn/{pageNumber}")]
        public async Task<IActionResult> GetListByLanguage(int languagePath, int pageSize, int pageNumber)
        {
            return Ok(await Mediator.Send(new GetErrorMessageByLanguageQuery() { LanguageId = languagePath, PageSize = pageSize, PageNumber = pageNumber }));
        }
    }
}
