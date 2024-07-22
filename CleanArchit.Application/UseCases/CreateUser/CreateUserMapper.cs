using AutoMapper;
using CleanArchit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchit.Application.UseCases.CreateUser
{
    public sealed class CreateUserMapper : Profile

    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();

        }

    }
}
