using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.UpdateBrand;

public record UpdateBrandCommand(UpdateBrandRequest Request) : IRequest<int>;

