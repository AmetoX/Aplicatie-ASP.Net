using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AplicatieASP.Components.DataBase.Models;

namespace AplicatieASP.Components.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUsersAsync();
            return View(users);
        }
    }
}
