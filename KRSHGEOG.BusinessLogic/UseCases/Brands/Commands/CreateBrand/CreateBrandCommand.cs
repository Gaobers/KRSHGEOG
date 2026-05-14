using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;

public record CreateBrandCommand(CreateBrandRequest Request) : IRequest<int>;
