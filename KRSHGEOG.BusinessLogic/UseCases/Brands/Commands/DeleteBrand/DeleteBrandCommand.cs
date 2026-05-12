using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.DeleteBrand;

public record DeleteBrandCommand(int Id) : IRequest<int>;

