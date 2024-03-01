using System.Security.Principal;

namespace LimakAzFrontToBack.Application.DTOs.AuthDTOs;

public class ForgetPasswordDto
{
    public string Email { get; set; } = null!;
}

