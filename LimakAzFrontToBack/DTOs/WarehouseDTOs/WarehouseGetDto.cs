﻿using LimakAzFrontToBack.Application.DTOs.DeliveryAreaDTOs;
using LimakAzFrontToBack.Application.DTOs.OrderDTOs;

namespace LimakAzFrontToBack.DTOs;

public class WarehouseGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Position { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string WorkingHours { get; set; } = null!;
    public List<OrderRelationDto> Orders { get; set; } = new List<OrderRelationDto>();
    public List<DeliveryAreaRelationDto> DeliveryAreas { get; set; } = new List<DeliveryAreaRelationDto>();
}
