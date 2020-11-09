using AutoMapper;
using CommandAPI.Dtos;
using CommandAPI.Models;
namespace CommandAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();//read
            CreateMap<CommandCreateDto, Command>();//create
            CreateMap<CommandUpdateDto, Command>();//update
            CreateMap<Command, CommandUpdateDto>();//partial update
        }
    }
}