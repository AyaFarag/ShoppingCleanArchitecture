using Microsoft.AspNetCore.Mvc;
using Shopping.Application.Contracts.Infrastructure.Interfaces;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private IAuthenticationService _authService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authService = authenticationService;
        }

        [HttpPost("login")]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost("logout")]
        public IActionResult logout()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult register()
        {
            return View();
        }
    }
}
