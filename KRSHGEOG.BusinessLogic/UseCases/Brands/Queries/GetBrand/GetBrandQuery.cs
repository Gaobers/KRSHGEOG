using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Queries.GetBrand;

public record GetBrandQuery(int Id) : IRequest<BrandResponse>;

