using LimakAzFrontToBack.Application.DTOs.DeliveryAreaDTOs;
using LimakAzFrontToBack.Application.DTOs.OrderDTOs;

namespace LimakAzFrontToBack.DTOs;

public class DeliveryGetDto
{
    public int Id { get; set; }
    public string Region { get; set; } = null!;
    public string Village { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string HomeNo { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Notes { get; set; } = null!;
    public bool IsCancel { get; set; } = false;
    public int DeliveryAreaId { get; set; }
    public int AppUserId { get; set; }
    public AppUserRelationDto AppUser { get; set; } = null!;
    public List<OrderRelationDto> Orders { get; set; } = new List<OrderRelationDto>();
    public DeliveryAreaRelationDto DeliveryArea { get; set; } = null!;
}
