using System.Collections.Generic;
using System.Linq;
using DotNet_DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_DemoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam" },
            new Character { Id = 2, Name = "Fuck" }
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}