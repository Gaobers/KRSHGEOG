using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;

public record CreateBrandCommand(CreateBrandRequest Request) : IRequest<int>;
