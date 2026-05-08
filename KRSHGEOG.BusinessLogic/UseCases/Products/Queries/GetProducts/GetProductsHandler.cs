using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.BusinessLogic.UseCases.Products.Specifications;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Queries.GetProducts
{
    internal sealed class GetProductsHandler(IEfRepository<HardwareProduct> _repository) : IRequestHandler<GetProductsQuery, List<ProductoResponse>>
    {
        public async Task<List<ProductoResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var productos = await _repository.ListAsync(new GetProductWithBrandSpec(), cancellationToken);

            if (productos == null && !productos.Any())
            {
                return new List<ProductoResponse>();
            }

            return productos.Adapt<List<ProductoResponse>>();
        }
    }
}
