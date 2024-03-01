using LimakAzFrontToBack.DTOs;
using LimakAzFrontToBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace LimakAzFrontToBack.Controllers;

public class LoginController : Controller
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://localhost:44345/auth/Login";
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    public LoginController(HttpClient httpClient, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _httpClient = httpClient;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Index(LoginDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);


        var user = await _userManager.FindByEmailAsync(dto.Email);

        if (user is null)
        {
            ModelState.AddModelError("", "Şifrə və ya email yanlışdır");
            return View();
        }


        if (!user.EmailConfirmed)
        {

            ModelState.AddModelError("", "İstifadəçi emaili təsdiq olunmayıb zəhmət olmasa email qutunuzu yoxlayın.");
            return View();
        }

        var result = await _signInManager.PasswordSignInAsync(user, dto.Password, true, true);


        if (result.IsLockedOut)
            ModelState.AddModelError("", "İstifadəçi blok olunub 5 dəqiqə sonra yoxlayın.");
        else
            ModelState.AddModelError("", "Şifrə və ya email yanlışdır");

        var request = new HttpRequestMessage(HttpMethod.Post, BaseUrl);

        var body = new
        {
            Email = dto.Email,
            Password = dto.Password
        };

        string json = System.Text.Json.JsonSerializer.Serialize(body);

        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {

            var token = await response.Content.ReadFromJsonAsync<AccessToken>();
            Response.Cookies.Append("token", token?.Token ?? "null");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token?.Token);


            if (result.Succeeded)
                return RedirectToAction("Index", "UserPanel");
        }

        var requestResult = JsonConvert.DeserializeObject<ResultDto>(content);

        ModelState.AddModelError("", requestResult?.message ?? String.Empty);



        return View(dto);
    }




    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        return RedirectToAction("Index");
    }
}









