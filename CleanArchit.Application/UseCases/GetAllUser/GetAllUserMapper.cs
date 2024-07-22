using AutoMapper;
using CleanArchit.Domain.Entities;

namespace CleanArchit.Application.UseCases.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}