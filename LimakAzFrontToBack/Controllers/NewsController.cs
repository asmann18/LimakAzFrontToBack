using LimakAzFrontToBack.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LimakAzFrontToBack.Controllers
{
    public class NewsController : Controller
    {
        private readonly HttpClient _httpClient;

        public NewsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/news");
            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadFromJsonAsync<List<NewsGetDto>>();
                return View(content);
            }

            return NotFound();
        }

        public async Task<IActionResult> Detail(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:44345/news/{id}");
            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadFromJsonAsync<NewsGetDto>();
                return View(content);
            }

            return NotFound();

        }
    }
}
