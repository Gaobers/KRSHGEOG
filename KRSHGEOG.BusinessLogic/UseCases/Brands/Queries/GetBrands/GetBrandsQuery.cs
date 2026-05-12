using KRSHGEOG.BusinessLogic.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Queries.GetBrands;

public record GetBrandsQuery() : IRequest< List <BrandResponse>>;