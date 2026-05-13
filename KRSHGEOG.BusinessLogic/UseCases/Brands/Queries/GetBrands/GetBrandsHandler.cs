using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Queries.GetBrands;

internal sealed class GetBrandsHandler(IEfRepository<ToolBrand> _repository)
    : IRequestHandler<GetBrandsQuery, List<BrandResponse>>
{
    public async Task<List<BrandResponse>> Handle(GetBrandsQuery query, CancellationToken cancellationToken)
    {
        var brands = await _repository.ListAsync(cancellationToken);

        if (brands == null || !brands.Any())
        {
            return new List<BrandResponse>();
        }
        return brands.Adapt<List<BrandResponse>>();
    }
}
