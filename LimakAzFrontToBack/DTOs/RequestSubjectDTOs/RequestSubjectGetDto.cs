using LimakAzFrontToBack.Application.DTOs.RequestDTOs;

namespace LimakAzFrontToBack.Application.DTOs.RequestSubjectDTOs;

public class RequestSubjectGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<RequestRelationDto> Requests { get; set; } = new List<RequestRelationDto>();

}
