using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Commands.UpdateUser;

public record UpdateUserCommand(UpdateUserRequest Request) : IRequest<int>;
