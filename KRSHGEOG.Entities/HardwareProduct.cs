using System;
using System.Collections.Generic;

namespace KRSHGEOG.Entities;

public partial class HardwareProduct
{
    public long Id { get; set; }

    public int ToolBrandId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? SalePrice { get; set; }

    public int? StockUnits { get; set; }

    public virtual ToolBrand ToolBrand { get; set; } = null!;
}
