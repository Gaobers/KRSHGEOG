using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Commands.UpdateUser;

internal sealed class UpdateUserHandler(IEfRepository<User> _repository)
    : IRequestHandler<UpdateUserCommand, int>
{
    public async Task<int> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var usuarioExistente = await _repository.GetByIdAsync(command.Request.Id, cancellationToken);

            if (usuarioExistente is null) return 0;

            usuarioExistente = command.Request.Adapt(usuarioExistente);
            await _repository.UpdateAsync(usuarioExistente, cancellationToken);

            return usuarioExistente.Id;
        }
        catch (Exception)
        {
            return 0;
            throw;
        }
    }
}
