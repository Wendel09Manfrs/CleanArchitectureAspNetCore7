using AutoMapper;
using CleanArchit.Domain.Entities;

namespace CleanArchit.Application.UseCases.DeleteUser;

public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteUserRequest, User>();
        CreateMap<User, DeleteUserResponse>();
    }
}