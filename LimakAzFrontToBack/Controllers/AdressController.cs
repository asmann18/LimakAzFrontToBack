using Microsoft.AspNetCore.Mvc;

namespace LimakAzFrontToBack.Controllers;

public class AdressController : Controller
{
    private readonly HttpClient _httpClient;

    public AdressController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/settings");
        var response=await _httpClient.SendAsync(request);

        if(response.IsSuccessStatusCode)
        {
            var content=await response.Content.ReadFromJsonAsync<Dictionary<string,string>>();
            return View(content);
        }
        return BadRequest();
    }
}









