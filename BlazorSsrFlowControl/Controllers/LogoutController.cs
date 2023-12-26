using Microsoft.AspNetCore.Mvc;

namespace BlazorServerProductionControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogoutController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Response.Cookies.Delete("ProdControlSessionToken");
            return Redirect("/");
        }
    }
}
