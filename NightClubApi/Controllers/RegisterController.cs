using Microsoft.AspNetCore.Http;
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
                return BadRequest("Check if you age more than 18 and less then 30");
            }

            return Ok("You have been registered successfully");
        }
    }
}
