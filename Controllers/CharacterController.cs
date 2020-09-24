using DotNet_DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_DemoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private static Character knight = new Character();
        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}