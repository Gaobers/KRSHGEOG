using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Commands.CreateProduct;

public record CreateProductCommand(SolicitudCrearProducto Request) : IRequest<long>;
