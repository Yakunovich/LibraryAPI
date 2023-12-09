using AutoMapper;
using Identity.Application.Features.Command.Login;
using Identity.Core.Entities;

namespace Identity.Application.Mapper.Profiles
{
    public class LoginMappingProfile : Profile
    {
        public LoginMappingProfile()
        {
            CreateMap<LoginCommandRequest, User>();

        }
    }
}
