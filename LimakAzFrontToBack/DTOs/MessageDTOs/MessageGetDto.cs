using LimakAzFrontToBack.Application.DTOs.AuthDTOs;
using LimakAzFrontToBack.Application.DTOs.ChatDTOs;
using LimakAzFrontToBack.DTOs;

namespace LimakAzFrontToBack.Application.DTOs.MessageDTOs;

public class MessageGetDto
{
    public int Id { get; set; }
    public int ChatId { get; set; }
    public ChatRelationDto Chat { get; set; } = null!;
    public string Body { get; set; } = null!;
    public string? FilePath { get; set; }
    public DateTime CreatedTime { get; set; }
    public int AppUserId { get; set; }
    public AppUserRelationDto AppUser { get; set; } = null!;
}
