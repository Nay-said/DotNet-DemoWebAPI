using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet_DemoWebAPI.Models;

namespace DotNet_DemoWebAPI.Services
{
    public interface IcharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCHaracter);
    }
} 