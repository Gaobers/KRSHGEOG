using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Queries.GetUsers;

public record GetUsersQuery() : IRequest<List<UserResponse>>;