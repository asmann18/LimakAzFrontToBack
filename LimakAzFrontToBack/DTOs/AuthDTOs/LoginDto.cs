using System.ComponentModel.DataAnnotations;

namespace LimakAzFrontToBack.DTOs;
public class LoginDto
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }=null!;

}

