using Application.Features.Books.Command.Add;
using AutoMapper;
using Core.Entities;

namespace Application.Mapper.Profiles
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<Book, CreateBookResponse>();
            CreateMap<CreateBookRequest, Book>();
        }

    }
}
