using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Queries.GetUsers;

internal sealed class GetUsersHandler(IEfRepository<User> _repository)
    : IRequestHandler<GetUsersQuery, List<UserResponse>>
{
    public async Task<List<UserResponse>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
    {
        var usuarios = await _repository.ListAsync(cancellationToken);

        if (usuarios == null || !usuarios.Any())
        {
            return new List<UserResponse>();
        }

        return usuarios.Adapt<List<UserResponse>>();
    }
}