using System.Runtime;
using ErrorMessageService.Entities.Base;

namespace ErrorMessageService.Entities.Dto;

public class ErrorMessageByStatusCodeDto
{
    public int SubStatusCode { get; set; }
    public int StatusCode { get; set; }
    public string Name { get; set; }
    public string Decription { get; set; }

    public int LanguageId { get; set; }
}