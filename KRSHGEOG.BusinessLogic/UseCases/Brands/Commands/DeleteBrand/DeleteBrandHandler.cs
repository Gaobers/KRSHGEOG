using KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;
using KRSHGEOG.DataAccess.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.DeleteBrand;

internal sealed class DeleteBrandHandler(IEfRepository<Brand> _repository)
    : IRequestHandler<DeleteBrandCommand, int>
{
    public async Task<int> Handle(DeleteBrandCommand command, CancellationToken cancellationToken)
    {
        var existingBrand = await _repository.GetByIdAsync(command.Id);

        if (existingBrand is null) return 0;

        await _repository.DeleteAsync(existingBrand, cancellationToken);

        return existingBrand.Id;

    }
}
