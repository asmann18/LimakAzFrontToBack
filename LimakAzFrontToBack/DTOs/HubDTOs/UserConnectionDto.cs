namespace LimakAzFrontToBack.Application.DTOs.HubDTOs;

public class UserConnectionDto
{
    public int UserId { get; set; }
    public List<string> ConnectionIds { get; set; }=new List<string>();
}
