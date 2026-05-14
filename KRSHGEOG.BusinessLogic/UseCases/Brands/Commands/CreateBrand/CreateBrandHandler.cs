using KRSHGEOG.DataAccess.Interfaces;
using KRSHGEOG.Entities;
using Mapster;
using MediatR;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;

internal sealed class CreateBrandHandler(IEfRepository<ToolBrand> _repository)
: IRequestHandler<CreateBrandCommand, int>
{
    public async Task<int> Handle(CreateBrandCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var newBrand = command.Request.Adapt<ToolBrand>();

            var createdBrand = await _repository.AddAsync(newBrand, cancellationToken);

            return createdBrand.Id;
        }
        catch (Exception)
        {
            //return 0;
            throw;
        }
    }
}

