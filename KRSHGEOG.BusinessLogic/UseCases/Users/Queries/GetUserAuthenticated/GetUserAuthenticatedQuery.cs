using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Queries.GetUserAuthenticated;

public record GetUserAuthenticatedQuery(string Username, string Password)
    : IRequest<UserResponse>;
