using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Commands.CreateUser;

public record CreateUserCommand(CreateUserRequest Request) : IRequest<int>;
