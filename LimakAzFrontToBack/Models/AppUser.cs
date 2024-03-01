using Microsoft.AspNetCore.Identity;

namespace LimakAzFrontToBack.Models;

public class AppUser:IdentityUser<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string SeriaNumber { get; set; }
    public string FinCode { get; set; }
    public DateTime Birtday { get; set; }
    public string Location { get; set; }
    public decimal AZNBalance { get; set; }
    public decimal TRYBalance { get; set; }
    public decimal USDBalance { get; set; }

    public int GenderId { get; set; }

    public int CitizenshipId { get; set; }
    public int UserPositionId { get; set; }

    public int WarehouseId { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiredAt { get; set; }
}




