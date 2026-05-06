using System;
using System.Collections.Generic;

namespace KRSHGEOG.Entities;

public partial class ToolBrand
{
    public int Id { get; set; }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<HardwareProduct> HardwareProducts { get; set; } = new List<HardwareProduct>();
}
