using FluentValidation;

namespace CleanArchit.Application.UseCases.DeleteUser;

public class DeleteUserValidator :
    AbstractValidator<DeleteUserRequest>
{
    public DeleteUserValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}