using MediatR;

namespace CleanArchit.Application.UseCases.DeleteUser;

public sealed record DeleteUserRequest(Guid Id)
                  : IRequest<DeleteUserResponse>;