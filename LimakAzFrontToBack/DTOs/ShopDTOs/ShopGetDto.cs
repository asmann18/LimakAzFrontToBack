using LimakAzFrontToBack.CategoryDTOs;

namespace LimakAzFrontToBack.DTOs;

public record ShopGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ImagePath { get; set; } = null!;
    public string WebsitePath { get; set; } = null!;

    public List<CategoryRelationDto> Categories { get; set; } = new List<CategoryRelationDto>();

}
