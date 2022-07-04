using Microsoft.AspNetCore.Mvc;
using NightClubApi.Models;

namespace NightClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create([FromBody] ClientRegister model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok("You have been registered successfully");
        }
    }
}
