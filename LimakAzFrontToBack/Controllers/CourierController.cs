﻿using LimakAzFrontToBack.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace LimakAzFrontToBack.Controllers;

public class CourierController : Controller
{
    private readonly HttpClient _httpClient;

    public CourierController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {


        var token = Request.Cookies["token"];

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44345/deliveries");
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content=await response.Content.ReadFromJsonAsync<List<DeliveryGetDto>>();
            return View(content);
        }


        return RedirectToAction("Logout", "Login");
    }
}









