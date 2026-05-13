using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Commands.CreateProduct;

internal sealed class CreateProductHandler(IEfRepository<HardwareProduct> _repository)
    : IRequestHandler<CreateProductCommand, long>
{
    public async Task<long> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var nuevoProducto = command.Request.Adapt<HardwareProduct>();
            var crearProducto = await _repository.AddAsync(nuevoProducto, cancellationToken);
            return crearProducto.Id;
        }
        catch (Exception)
        {
            return 0;
            throw;
        }
    }
}
