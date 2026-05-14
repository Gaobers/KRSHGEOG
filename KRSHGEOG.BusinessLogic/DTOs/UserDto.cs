using System.ComponentModel.DataAnnotations;

namespace KRSHGEOG.BusinessLogic.DTOs;

public class UserResponse
{
    public int Id { get; set; }
    public int RoleId { get; set; }
    public string Username { get; set; } = null!;
    public string? PasswordHash { get; set; }
}

public class CreateUserRequest
{
    [Required(ErrorMessage = "Debe seleccionar un rol")]
    [Display(Name = "Rol")]
    public int RoleId { get; set; }

    [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
    [StringLength(50, ErrorMessage = "El usuario no puede superar los 50 caracteres")]
    [Display(Name = "Usuario")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [StringLength(255, MinimumLength = 5, ErrorMessage = "La contraseña debe tener al menos 5 caracteres")]
    [Display(Name = "Contraseña")]
    public string? PasswordHash { get; set; }
}

public class UpdateUserRequest
{
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un rol")]
    [Display(Name = "Rol")]
    public int RoleId { get; set; }

    [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
    [StringLength(50, ErrorMessage = "El usuario no puede superar los 50 caracteres")]
    [Display(Name = "Usuario")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [StringLength(255, MinimumLength = 5, ErrorMessage = "La contraseña debe tener al menos 5 caracteres")]
    [Display(Name = "Contraseña")]
    public string? PasswordHash { get; set; }
}

public class RoleResponse
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class UserByIdResponse
{
    public int Id { get; set; }
    public int RoleId { get; set; }
    public string Username { get; set; } = null!;
    public string? PasswordHash { get; set; }
}