using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Commands.UpdateProduct
{
    public record UpdateProductCommand(SolicitudActualizarProducto Request) : IRequest<long>;
}
