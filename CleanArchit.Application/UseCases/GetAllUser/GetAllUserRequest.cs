using MediatR;

namespace CleanArchit.Application.UseCases.GetAllUser;

public sealed record GetAllUserRequest :
                   IRequest<List<GetAllUserResponse>>;