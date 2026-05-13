using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;
using KRSHGEOG.DataAccess.Interfaces;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Queries.GetBrand;

internal sealed class GetBrandHandler(IEfRepository<Brand> _repository)
    : IRequestHandler<GetBrandQuery, BrandResponse>
{
    public async Task<BrandResponse> Handle(GetBrandQuery query, CancellationToken cancellationToken)
    {
        var brand = await _repository.GetByIdAsync(query.Id, cancellationToken);

        if (brand is null) {
            return new BrandResponse();
        }
        return brand.Adapt<BrandResponse>();
    }
}

