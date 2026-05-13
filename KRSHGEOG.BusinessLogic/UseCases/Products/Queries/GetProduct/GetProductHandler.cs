using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Queries.GetProduct
{
    internal sealed class GetProductHandler(IEfRepository<HardwareProduct> _repository) : IRequestHandler<GetProductQuery, ProductoByIdResponse>
    {
        public async Task<ProductoByIdResponse> Handle(GetProductQuery query, CancellationToken cancellationToken)
        {
            var producto = await _repository.GetByIdAsync(query.Id, cancellationToken);

            if (producto is null)
            {
                return new ProductoByIdResponse();
            }

            return producto.Adapt<ProductoByIdResponse>();
        }
    }
}
