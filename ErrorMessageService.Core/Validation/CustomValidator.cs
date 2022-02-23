using Core.Wrappers;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace Core.Validation
{
    public class CustomValidator<T> : AbstractValidator<T>, IRequest<IResponse>
    {
        public override ValidationResult Validate(ValidationContext<T> context)
        {
            var validationResult = base.Validate(context);
            if (!validationResult.IsValid)
            {
                validationResult.Errors.ToList();
            }

            return validationResult;
        }
    }
}
