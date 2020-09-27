using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNet_DemoWebAPI.Dtos;
using DotNet_DemoWebAPI.Models;

namespace DotNet_DemoWebAPI.Services
{
  public class CharacterService : IcharacterService
  {
    private static List<Character> characters = new List<Character> {
        new Character(),
        new Character { Id = 1, Name = "Sam" }
    };
    
    private readonly IMapper _mapper;
    public CharacterService(IMapper mapper)
    {
        _mapper = mapper;
    }
    public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
    {
        ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
        Character character = _mapper.Map<Character>(newCharacter);
        character.Id = characters.Max(c => c.Id) + 1;
        characters.Add(character);
        serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
    {
      ServiceResponse<List<GetCharacterDto>> serviceResponse =  new ServiceResponse<List<GetCharacterDto>>();
      serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
      return serviceResponse;
    }

    public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
    {
      ServiceResponse<GetCharacterDto> serviceResponse =  new ServiceResponse<GetCharacterDto>();
      serviceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));
      return serviceResponse;
    }
  }
}