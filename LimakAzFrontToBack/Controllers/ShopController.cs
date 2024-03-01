using LimakAzFrontToBack.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LimakAzFrontToBack.Controllers;

public class ShopController : Controller
{
    private readonly HttpClient _httpClient;
    private string ShopsUrl = "https://localhost:44345/shops";
    private const string CategoriesUrl = "https://localhost:44345/categories";
    private const string CountriesUrl = "https://localhost:44345/countries";

    public ShopController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index(int countryId = 0, int categoryId = 0, int page = 1)
    {

        ShopsUrl += $"?country={countryId}&category={categoryId}&page={page}";

        var shopRequest = new HttpRequestMessage(HttpMethod.Get, ShopsUrl);
        var shopResponse = await _httpClient.SendAsync(shopRequest);

        var categoryRequest = new HttpRequestMessage(HttpMethod.Get, CategoriesUrl);
        var categoryResponse = await _httpClient.SendAsync(categoryRequest);

        var countryRequest = new HttpRequestMessage(HttpMethod.Get, CountriesUrl);
        var countryResponse = await _httpClient.SendAsync(countryRequest);

        if (shopResponse.IsSuccessStatusCode && categoryResponse.IsSuccessStatusCode && countryResponse.IsSuccessStatusCode)
        {
            var shopContent = await shopResponse.Content.ReadAsStringAsync();
            var shops = JsonConvert.DeserializeObject<List<ShopGetDto>>(shopContent);


            var categoryContent = await categoryResponse.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<CategoryGetDto>>(categoryContent);




            var countryContent = await countryResponse.Content.ReadAsStringAsync();
            var countries = JsonConvert.DeserializeObject<List<CountryGetDto>>(countryContent);


            ShopPageVM vm = new() { Shops = shops ?? new(), Categories = categories ?? new(), Countries = countries ?? new() };

            ViewBag.CountryId = countryId;
            ViewBag.CategoryId = categoryId;
            ViewBag.Page = page;

            return View(vm);
        }


        return NotFound();
    }


}









