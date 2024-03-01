using Microsoft.AspNetCore.Http;

namespace LimakAzFrontToBack.Application.DTOs.ShopDTOs;

public record ShopPostDto
{
    public string Name { get; init; }
    public IFormFile Image{ get; set; }
    public string WebsitePath{ get; set; }
    public List<int> CategoryIds{ get; set; }
    public int CountryId { get; set; }

}
