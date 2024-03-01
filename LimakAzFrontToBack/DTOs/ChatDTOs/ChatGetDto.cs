using LimakAzFrontToBack.Application.DTOs.AuthDTOs;
using LimakAzFrontToBack.Application.DTOs.MessageDTOs;
using LimakAzFrontToBack.DTOs;

namespace LimakAzFrontToBack.Application.DTOs.ChatDTOs;

public class ChatGetDto
{
    public int Id { get; set; }
    public int AppUserId { get; set; }
    public AppUserRelationDto AppUser { get; set; } = null!;
    public int OperatorId { get; set; }
    public AppUserRelationDto Operator { get; set; } = null!;
    public bool IsActive { get; set; }
    public List<MessageRelationDto> Messages { get; set; } = new();
}
