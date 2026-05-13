using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.BusinessLogic.UseCases.Users.Specifications;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Queries.GetUserAuthenticated;

internal sealed class GetUserAuthenticatedHandler(IEfRepository<User> _repository)
    : IRequestHandler<GetUserAuthenticatedQuery, UserResponse>
{
    public async Task<UserResponse> Handle(GetUserAuthenticatedQuery query, CancellationToken cancellationToken)
    {
        var usuario = await _repository.FirstOrDefaultAsync(new GetUserAuthenticatedSpec(query.Username, query.Password), cancellationToken);

        if (usuario is null)
        {
            return new UserResponse();
        }

        return usuario.Adapt<UserResponse>();
    }
}
