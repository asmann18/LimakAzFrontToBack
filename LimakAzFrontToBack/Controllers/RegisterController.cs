using LimakAzFrontToBack.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace LimakAzFrontToBack.Controllers;

public class RegisterController : Controller
{

    private const string BaseUrl = "https://localhost:44345/auth/Register";
    private readonly HttpClient _httpClient;

    public RegisterController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(RegisterDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);
        var request = new HttpRequestMessage(HttpMethod.Post, BaseUrl);

        var body = new
        {
            dto.Name,
            dto.Surname,
            dto.SeriaNumber,
            dto.FinCode,
            dto.PhoneNumber,
            dto.Email,
            dto.Password,
            dto.ConfirmPassword,
            dto.Location,
            dto.Birtday,
            dto.CitizenshipId,
            dto.WarehouseId,
            dto.GenderId,
            dto.UserPositionId,
            
        };

        string json = System.Text.Json.JsonSerializer.Serialize(body);

        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index", "Login");
        }
        var result = JsonConvert.DeserializeObject<ResultDto>(content);

        ModelState.AddModelError("", result?.message ?? String.Empty);

        return View(dto);
    }
}









