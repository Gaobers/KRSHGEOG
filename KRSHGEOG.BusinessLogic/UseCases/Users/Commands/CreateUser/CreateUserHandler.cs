using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Commands.CreateUser;

internal sealed class CreateUserHandler(IEfRepository<User> _repository)
    : IRequestHandler<CreateUserCommand, int>
{
    public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var nuevoUsuario = command.Request.Adapt<User>();
            var crearUsuario = await _repository.AddAsync(nuevoUsuario, cancellationToken);
            return crearUsuario.Id;
        }
        catch (Exception)
        {
            return 0;
            throw;
        }

    }
}
