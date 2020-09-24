using DotNet_DemoGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_DemoGame.Controllers
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