using LimakAzFrontToBack.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LimakAzFrontToBack.Controllers;

public class TariffController : Controller
{
    private readonly HttpClient _httpClient;

    public TariffController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {

        TariffVM vm = new();

        var turkeyTariff = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/tariffs/GetByCountry/1");
        var tariffResponse1 = await _httpClient.SendAsync(turkeyTariff);

        if (tariffResponse1.IsSuccessStatusCode)
        {
            var turkeyTariffs = await tariffResponse1.Content.ReadFromJsonAsync<List<TariffGetDto>>();
            vm.TurkeyTariffs = turkeyTariffs?.ToList() ?? new();
        }



        var americaTariff = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/tariffs/GetByCountry/2");
        var tariffResponse2 = await _httpClient.SendAsync(americaTariff);

        if (tariffResponse2.IsSuccessStatusCode)
        {
            var americaTariffs = await tariffResponse2.Content.ReadFromJsonAsync<List<TariffGetDto>>();
            vm.AmericaTariffs = americaTariffs?.ToList() ?? new();
        }
        return View(vm);
    }
}









