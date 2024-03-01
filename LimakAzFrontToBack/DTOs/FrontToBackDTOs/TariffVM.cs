namespace LimakAzFrontToBack.DTOs;

public class TariffVM
{
    public List<TariffGetDto> TurkeyTariffs { get; set; } = new();
    public List<TariffGetDto> AmericaTariffs { get; set; } = new();
}
