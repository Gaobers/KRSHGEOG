using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Queries.GetProduct;

public record GetProductQuery(long Id) : IRequest<ProductoByIdResponse>;
