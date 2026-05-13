using KRSHGEOG.Entities;

namespace KRSHGEOG.BusinessLogic.DTOs;

public class SolicitudCrearProducto
{
    public int ToolBrandId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? SalePrice { get; set; }

    public int? StockUnits { get; set; }
}

public class SolicitudActualizarProducto
{
    public long Id { get; set; }

    public int ToolBrandId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? SalePrice { get; set; }

    public int? StockUnits { get; set; }
}

public class ProductoResponse
{
    public long Id { get; set; }

    public int ToolBrandId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? SalePrice { get; set; }

    public int? StockUnits { get; set; }
}


public class ProductoByIdResponse
{
    public long Id { get; set; }

    public int ToolBrandId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? SalePrice { get; set; }

    public int? StockUnits { get; set; }
}