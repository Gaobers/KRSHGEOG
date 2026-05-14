using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Queries.GetBrand;

internal sealed class GetBrandHandler(IEfRepository<ToolBrand> _repository)
    : IRequestHandler<GetBrandQuery, BrandResponse>
{
    public async Task<BrandResponse> Handle(GetBrandQuery query, CancellationToken cancellationToken)
    {
        var brand = await _repository.GetByIdAsync(query.Id, cancellationToken);

        if (brand is null)
        {
            return new BrandResponse();
        }
        return brand.Adapt<BrandResponse>();
    }
}

