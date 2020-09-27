using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet_DemoWebAPI.Dtos;
using DotNet_DemoWebAPI.Models;
using DotNet_DemoWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_DemoWebAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CharacterController : ControllerBase
  {
    private readonly IcharacterService _characterService;

    public CharacterController(IcharacterService characterService)
    {
      _characterService = characterService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> Get()
    {
      return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSingle(int id)
    {
      return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
    {
      return Ok(await _characterService.AddCharacter(newCharacter));
    }
  }
}