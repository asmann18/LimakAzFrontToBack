namespace LimakAzFrontToBack.Application.DTOs.AuthDTOs;

public class ForgetPasswordTokenDto
{
    public string AppUserId { get; set; } = null!;
    public string Token { get; set; } = null!;
}

