using BlazorServerProductionControl.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerProductionControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController(AuthenticationService authService) : ControllerBase
    {
        private readonly AuthenticationService _authService = authService;

        [HttpPost]
        public IActionResult Post([FromForm] string username, [FromForm] string password)
        {
            var user = _authService.Authenticate(username, password);
            if (user != null)
            {
                var sessionToken = username;

                Response.Cookies.Append("ProdControlSessionToken", sessionToken, new CookieOptions
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.Lax
                });

                if (username == "admin")
                {
                return Redirect("/orders");
                }
                if (username == "soldadura")
                {
                    return Redirect("/deliveries");
                }
            }

            return BadRequest("Invalid credentials");
        }

    }
}
