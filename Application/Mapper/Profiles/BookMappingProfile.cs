using Application.Features.Books.Command.Add;
using Application.Features.Books.Command.Delete;
using Application.Features.Books.Command.Update;
using Application.Features.Books.Queries.GetAll;
using Application.Features.Books.Queries.GetById;
using Application.Features.Books.Queries.GetByISBN;
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

            CreateMap<GetAllBooksRequest, Book>();
            CreateMap<Book, GetAllBooksResponse>();

            CreateMap<Book, GetBookByIdResponse>();

            CreateMap<Book, GetBookByISBNResponse>();

            CreateMap<int, DeleteBookResponse>();
            CreateMap<DeleteBookRequest, Book>();

            CreateMap<UpdateBookRequest, Book>();
            CreateMap<Book, UpdateBookResponse>();

        }

    }
}
