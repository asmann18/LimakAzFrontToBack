﻿using LimakAzFrontToBack.Application.DTOs.DeliveryDTOs;
using LimakAzFrontToBack.Application.DTOs.KargomatDTOs;
using LimakAzFrontToBack.Application.DTOs.StatusDTOs;
using LimakAzFrontToBack.Application.DTOs.WarehouseDTOs;

namespace LimakAzFrontToBack.DTOs;

public class OrderGetDto
{
    public int Id { get; set; }
    public string OrderURL { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal LocalCargoPrice { get; set; } = 0;
    public decimal CargoPrice { get; set; }
    public decimal Weight { get; set; }
    public bool OrderPaymentStatus { get; set; } = false;
    public bool CargoPaymentStatus { get; set; } = false;
    public int Count { get; set; } = 1;
    public string Color { get; set; } = null!;
    public string Size { get; set; } = null!;
    public string Notes { get; set; } = null!;
    public decimal AdditionFees { get; set; } = 0;
    public string? AdditionFeesNotes { get; set; }
    public decimal OrderTotalPrice { get; set; }
    public decimal TotalPrice { get; set; } = 0;
    public bool IsCancel { get; set; } = false;
    public string? CancellationNotes { get; set; }
    //
    public int AppUserId { get; set; }
    public AppUserRelationDto AppUser { get; set; } = null!;

    public int? ShopId { get; set; } = null!;
    public ShopRelationDto? Shop{ get; set; }

    public int? DeliveryId { get; set; }
    public DeliveryRelationDto? Delivery { get; set; }

    public int WarehouseId { get; set; }
    public WarehouseRelationDto Warehouse { get; set; }=null!;

    public int? KargomatId { get; set; }
    public KargomatRelationDto? Kargomat { get; set; }

    public int StatusId { get; set; }
    public StatusRelationDto Status { get; set; } = null!;

    public int CountryId { get; set; }
    public CountryGetDto Country { get; set; } = null!;
    

}
