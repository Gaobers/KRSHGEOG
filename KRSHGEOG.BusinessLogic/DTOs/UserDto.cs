using KRSHGEOG.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
    public int RoleId { get; set; }
    public string Username { get; set; } = null!;
    public string? PasswordHash { get; set; }
}

public class UpdateUserRequest
{
    public int Id { get; set; }
    public int RoleId { get; set; }
    public string Username { get; set; } = null!;
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
