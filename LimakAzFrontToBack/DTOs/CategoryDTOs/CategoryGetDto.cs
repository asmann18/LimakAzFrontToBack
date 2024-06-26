﻿namespace LimakAzFrontToBack.DTOs;

public record CategoryGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ImagePath { get; set; } = null!;
    public List<ShopRelationDto> Shops { get; set; } = new();
    
}

