using System.ComponentModel.DataAnnotations;

namespace KRSHGEOG.BusinessLogic.DTOs
{
    public class CreateBrandRequest
    {
        [Required(ErrorMessage = "El nombre de la marca es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        [Display(Name = "Nombre de la Marca")]
        public string BrandName { get; set; } = null!;
    }

    public class UpdateBrandRequest
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la marca es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        [Display(Name = "Nombre de la Marca")]
        public string BrandName { get; set; } = null!;
    }

    public class BrandResponse
    {
        public int Id { get; set; }

        public string BrandName { get; set; } = null!;
    }
}