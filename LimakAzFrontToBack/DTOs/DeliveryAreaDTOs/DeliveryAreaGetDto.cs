using LimakAzFrontToBack.Application.DTOs.WarehouseDTOs;

namespace LimakAzFrontToBack.Application.DTOs.DeliveryAreaDTOs;

public class DeliveryAreaGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int WarehouseId { get; set; }
    public WarehouseRelationDto Warehouse { get; set; } = null!;
}
