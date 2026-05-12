using KRSHGEOG.DataAccess.Interfaces;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;

internal sealed class CreateBrandHandler(IEfRepository<Brand> _repository)
: IRequestHandler<CreateBrandCommand, int>
{
    public async Task<int> Handle(CreateBrandCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var newBrand = command.Request.Adapt<Brand>();

            var createdBrand = await _repository.AddAsync(newBrand, cancellationToken);
           
            return createdBrand.Id;
        }
        catch(Exception)
        {
            return 0;
            throw;
        }
    }
}

