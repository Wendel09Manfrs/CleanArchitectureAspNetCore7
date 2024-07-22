using CleanArchit.Application.UseCases.GetAllUser;
using FluentValidation;

namespace CleanArchitecture.Application.UseCases.GetAllUser;

public class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
{
    public GetAllUserValidator()
    {
        //sem validação    
    }
}