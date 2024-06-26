﻿namespace LimakAzFrontToBack.Application.DTOs.MessageDTOs;

public class MessageRelationDto
{
    public int Id { get; set; }
    public int ChatId { get; set; }
    public string Body { get; set; } = null!;
    public string? FilePath { get; set; }
    public DateTime CreatedTime { get; set; }
    public int AppUserId { get; set; }
}
