using LimakAzFrontToBack.DTOs;
using LimakAzFrontToBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LimakAzFrontToBack.ViewComponents;

public class UserPanelViewComponent : ViewComponent
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IHttpContextAccessor _contextAccessor;

    public UserPanelViewComponent(IHttpContextAccessor contextAccessor, UserManager<AppUser> userManager)
    {
        _contextAccessor = contextAccessor;
        _userManager = userManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        string id = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "0";


        var user = await _userManager.FindByIdAsync(id);

        if (user == null)
            throw new Exception();

        AppUserGetDto dto = new()
        {
            Id=user.Id,
            UserName=user.UserName,
            Name=user.Name,
            Surname=user.Surname,   
        };



        return View(dto);

    }
}
