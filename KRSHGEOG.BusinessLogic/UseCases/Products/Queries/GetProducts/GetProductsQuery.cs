using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Queries.GetProducts;

public record GetProductsQuery() : IRequest<List<ProductoResponse>>;
