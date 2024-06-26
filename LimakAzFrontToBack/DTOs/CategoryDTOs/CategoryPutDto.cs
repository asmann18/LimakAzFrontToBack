﻿using Microsoft.AspNetCore.Http;

namespace LimakAzFrontToBack.Application.DTOs.CategoryDTOs;

public record CategoryPutDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public IFormFile? Image{ get; set; }
}
