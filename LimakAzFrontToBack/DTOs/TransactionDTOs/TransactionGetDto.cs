using LimakAzFrontToBack.DTOs;

namespace LimakAzFrontToBack.DTOs;

public class TransactionGetDto
{
    public decimal Amount { get; set; }
    public bool IsPayment { get; set; }
    public string Feedback { get; set; } = null!;
    public decimal UserBalance { get; set; }
    public int AppUserId { get; set; }
    public DateTime CreatedTime { get; set; }
    public AppUserRelationDto AppUser { get; set; } = null!;
}
