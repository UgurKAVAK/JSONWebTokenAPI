using AuthServer.Core.DTOs;
using FluentValidation;

namespace JSONWebTokenAPI.Validations
{
    public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email İs Required").EmailAddress().WithMessage("Email İs Wrong");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password İs Required");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName İs Required");
        }
    }
}
