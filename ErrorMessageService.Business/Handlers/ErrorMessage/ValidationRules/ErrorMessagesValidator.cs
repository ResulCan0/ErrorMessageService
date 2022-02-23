using Core.Constants;
using Core.Constants.RegularEx;
using Core.Validation;
using Core.Wrappers;
using ErrorMessageService.Business.Handlers.ErrorMessage.Commands;
using FluentValidation;
using MediatR;

namespace ErrorMessageService.Business.Handlers.ValidationRules.ErrorMessage;

public class CreateErrorMessagesValidator:CustomValidator<CreateErrorMessageCommand>
{
    
    public CreateErrorMessagesValidator()
    {
        RuleFor(_ => _.SubStatusCode).NotEmpty().Must(RegularEx.IsNumeric);
        RuleFor(_ => _.StatusCode).NotEmpty().Must(RegularEx.IsNumeric);
        RuleFor(_ => _.Name).NotEmpty().Must(RegularEx.IsString);
        RuleFor(_ => _.Decription).NotEmpty().Must(RegularEx.IsString);
        RuleFor(_ => _.LanguageId);
    }
}
public class DeleteErrorMessagesValidator : CustomValidator<DeleteErrorMessageCommand>
{
    public DeleteErrorMessagesValidator()
    {
        RuleFor(_ => _.ErrorMessageId).NotEmpty().Must(RegularEx.IsNumeric);
    }
}