using AutoMapper;
using CleanArchit.Domain.Entities;

namespace CleanArchit.Application.UseCases.UpdateUser;

public sealed class UpdateUserMapper : Profile
{
    public UpdateUserMapper()
    {
        CreateMap<UpdateUserRequest, User>();
        CreateMap<User, UpdateUserResponse>();
    }
}