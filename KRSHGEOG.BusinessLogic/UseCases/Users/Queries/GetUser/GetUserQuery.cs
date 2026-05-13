using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Queries.GetUser;

public record GetUserQuery(int Id) : IRequest<UserByIdResponse>;