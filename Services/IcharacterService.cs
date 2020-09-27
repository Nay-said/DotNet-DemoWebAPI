using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet_DemoWebAPI.Dtos;
using DotNet_DemoWebAPI.Models;

namespace DotNet_DemoWebAPI.Services
{
    public interface IcharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCHaracter);
    }
} 