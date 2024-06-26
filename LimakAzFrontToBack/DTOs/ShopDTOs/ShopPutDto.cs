﻿using Microsoft.AspNetCore.Http;

namespace LimakAzFrontToBack.Application.DTOs.ShopDTOs;

public record ShopPutDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string WebsitePath { get; set; }

    public IFormFile? Image { get; init; }
    public List<int> CategoryIds { get; set; }
    public int CountryId { get; set; }

}
