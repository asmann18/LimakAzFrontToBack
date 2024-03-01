namespace LimakAzFrontToBack.DTOs;

public class IndexVM
{
    public List<BrandGetDto> Brands { get; set; } = new();
    public List<ShopGetDto> Shops { get; set; } = new();
    public List<NewsGetDto> News { get; set; } = new();
    public List<TariffGetDto> TurkeyTariffs { get; set; } = new();
    public List<TariffGetDto> AmericaTariffs { get; set; } = new();
}
