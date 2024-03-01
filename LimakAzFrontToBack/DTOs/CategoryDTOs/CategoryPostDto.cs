using Microsoft.AspNetCore.Http;

namespace LimakAzFrontToBack.Application.DTOs.CategoryDTOs;

public record CategoryPostDto
{
    public string Name { get; set; }
    public IFormFile Image { get; set; }
}
