﻿namespace LimakAzFrontToBack.DTOs;

public class NotificationGetDto
{
    public int Id { get; set; }
    public string Subject { get; set; } = null!;
    public string Title { get; set; } = null!;
    public int AppUserId { get; set; }
    public AppUserRelationDto AppUser { get; set; } = null!;
    public DateTime CreatedTime { get; set; }
    public bool IsRead { get; set; } 


}
