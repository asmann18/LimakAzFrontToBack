using Microsoft.AspNetCore.Http;

namespace LimakAzFrontToBack.Application.DTOs.BrandDTOs;

public class BrandPutDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public IFormFile? Image { get; set; } = null!;
    public string WebsitePath { get; set; } = null!;
}
