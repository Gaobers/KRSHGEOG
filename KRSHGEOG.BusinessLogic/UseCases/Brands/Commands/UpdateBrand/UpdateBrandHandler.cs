using KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;
using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.UpdateBrand;

internal sealed class UpdateBrandHandler(IEfRepository<ToolBrand> _repository)
    : IRequestHandler<UpdateBrandCommand, int>
{
    public async Task<int> Handle(UpdateBrandCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var existingBrand = await _repository.GetByIdAsync(command.Request.Id);

            if (existingBrand is null) return 0;

            existingBrand = command.Request.Adapt(existingBrand);

            await _repository.UpdateAsync(existingBrand, cancellationToken);

            return existingBrand.Id;

        }
        catch (Exception)
        {


            throw;

        }
    }
}
