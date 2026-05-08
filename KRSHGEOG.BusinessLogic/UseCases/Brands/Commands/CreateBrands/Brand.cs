using KRSHGEOG.Entities;

namespace KRSHGEOG.BusinessLogic.UseCases.Brands.Commands.CreateBrands;

internal class Brand
{
    public int Id { get; set; }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<HardwareProduct> HardwareProducts { get; set; } = new List<HardwareProduct>();
}
