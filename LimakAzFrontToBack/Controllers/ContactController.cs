using LimakAzFrontToBack.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LimakAzFrontToBack.Controllers;

public class ContactController : Controller
{
    private readonly HttpClient _httpClient;

    public ContactController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {

        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/warehouses");
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var warehouses = await response.Content.ReadFromJsonAsync<List<WarehouseGetDto>>();
            return View(warehouses);
        }

        return NotFound();
    }
}









