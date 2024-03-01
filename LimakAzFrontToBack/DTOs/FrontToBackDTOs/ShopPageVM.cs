namespace LimakAzFrontToBack.DTOs;

public class ShopPageVM
{
    public List<ShopGetDto> Shops { get; set; } = new();
    public List<CountryGetDto> Countries { get; set; } = new();
    public List<CategoryGetDto> Categories { get; set; } = new();
 
}
