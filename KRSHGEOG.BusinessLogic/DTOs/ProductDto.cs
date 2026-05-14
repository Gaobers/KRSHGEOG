using System.ComponentModel.DataAnnotations;

namespace KRSHGEOG.BusinessLogic.DTOs;

public class SolicitudCrearProducto
{
    [Required(ErrorMessage = "Debe seleccionar una marca")]
    [Display(Name = "Marca")]
    public int ToolBrandId { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio")]
    [StringLength(200, ErrorMessage = "El nombre no puede superar los 200 caracteres")]
    [Display(Name = "Nombre del Producto")]
    public string ProductName { get; set; } = null!;

    [Required(ErrorMessage = "El precio de venta es obligatorio")]
    [Range(0.01, 999999.99, ErrorMessage = "El precio debe ser mayor que 0")]
    [Display(Name = "Precio de Venta")]
    public decimal? SalePrice { get; set; }

    [Required(ErrorMessage = "Las existencias son obligatorias")]
    [Range(0, int.MaxValue, ErrorMessage = "Las existencias no pueden ser negativas")]
    [Display(Name = "Existencias")]
    public int? StockUnits { get; set; }
}

public class SolicitudActualizarProducto
{
    [Required]
    public long Id { get; set; }

    [Required(ErrorMessage = "Debe seleccionar una marca")]
    [Display(Name = "Marca")]
    public int ToolBrandId { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio")]
    [StringLength(200, ErrorMessage = "El nombre no puede superar los 200 caracteres")]
    [Display(Name = "Nombre del Producto")]
    public string ProductName { get; set; } = null!;

    [Required(ErrorMessage = "El precio de venta es obligatorio")]
    [Range(0.01, 999999.99, ErrorMessage = "El precio debe ser mayor que 0")]
    [Display(Name = "Precio de Venta")]
    public decimal? SalePrice { get; set; }

    [Required(ErrorMessage = "Las existencias son obligatorias")]
    [Range(0, int.MaxValue, ErrorMessage = "Las existencias no pueden ser negativas")]
    [Display(Name = "Existencias")]
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