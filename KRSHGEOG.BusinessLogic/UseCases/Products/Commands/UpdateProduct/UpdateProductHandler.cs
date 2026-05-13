using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Commands.UpdateProduct
{
    internal sealed class UpdateProductHandler(IEfRepository<HardwareProduct> _repository) : IRequestHandler<UpdateProductCommand, long>
    {
        public async Task<long> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var marcaExistente = await _repository.GetByIdAsync(command.Request.Id, cancellationToken);
                if (marcaExistente is null) return 0;

                marcaExistente = command.Request.Adapt(marcaExistente);

                await _repository.UpdateAsync(marcaExistente, cancellationToken);

                return marcaExistente.Id;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
    }
}
