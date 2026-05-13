using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Queries.GetUser;

internal sealed class GetUserHandler(IEfRepository<User> _repository)
    : IRequestHandler<GetUserQuery, UserByIdResponse>
{
    public async Task<UserByIdResponse> Handle(GetUserQuery query, CancellationToken cancellationToken)
    {
        var usuario = await _repository.GetByIdAsync(query.Id, cancellationToken);

        if (usuario == null)
        {
            return new UserByIdResponse();
        }
        return usuario.Adapt<UserByIdResponse>();
    }
}