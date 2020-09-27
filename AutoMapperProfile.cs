using AutoMapper;
using DotNet_DemoWebAPI.Models;
using DotNet_DemoWebAPI.Dtos;

namespace DotNet_DemoWebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
} 