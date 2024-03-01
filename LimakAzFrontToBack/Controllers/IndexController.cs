using LimakAzFrontToBack.DTOs;
using Microsoft.AspNetCore.Mvc;
namespace LimakAzFrontToBack.Controllers;

public class IndexController : Controller
{
    private readonly HttpClient _httpClient;

    public IndexController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {
        IndexVM vm = new();
        var brandRequest = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/brands");

        var brandResponse = await _httpClient.SendAsync(brandRequest);

        if (brandResponse.IsSuccessStatusCode)
        {
            var brandContent = await brandResponse.Content.ReadFromJsonAsync<List<BrandGetDto>>();
            vm.Brands = brandContent?.ToList() ?? new();

        }


        var shopRequest = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/shops");
        var shopResponse = await _httpClient.SendAsync(shopRequest);
        if (shopResponse.IsSuccessStatusCode)
        {
            var shopContent = await shopResponse.Content.ReadFromJsonAsync<List<ShopGetDto>>();
            vm.Shops = shopContent?.ToList() ?? new();
        }


        var newsRequest = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/news");
        var newsResponse = await _httpClient.SendAsync(newsRequest);

        if (newsResponse.IsSuccessStatusCode)
        {
            var newsContent = await newsResponse.Content.ReadFromJsonAsync<List<NewsGetDto>>();
            vm.News = newsContent?.ToList() ?? new();
        }


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