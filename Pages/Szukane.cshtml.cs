using Microsoft.AspNetCore.Mvc.RazorPages;
using ClaimsIdentity.Interfaces;
using ClaimsIdentity.Models;
using ClaimsIdentity.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace ClaimsIdentity.Pages
{
    [Authorize]

    public class SzukaneModel : PageModel
    {

        private readonly IUserService _userService;
        private readonly UserManager<IdentityUser> _userManager;

        public ListUserViewModel Records { get; set; }

        public string? CurrentUserId { get; set; }

        public SzukaneModel(IUserService userService, UserManager<IdentityUser> userManager)
        {
            _userService = userService;
            _userManager = userManager;

        }

        public void OnGet()
        {
            Records = _userService.GetPeople();
            CurrentUserId = _userManager.GetUserId(HttpContext.User);
        }
    }
}
