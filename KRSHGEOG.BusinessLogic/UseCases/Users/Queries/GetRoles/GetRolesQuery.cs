using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Queries.GetRoles;

public record GetRolesQuery : IRequest<List<RoleResponse>>;
