using Ardalis.Specification;
using KRSHGEOG.Entities;

namespace KRSHGEOG.BusinessLogic.UseCases.Products.Specifications
{
    public class GetProductWithBrandSpec : Specification<HardwareProduct>
    {
        public GetProductWithBrandSpec()
        {
            Query.Include(p => p.ToolBrand);
        }
    }
}
