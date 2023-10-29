using AutoMapper;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;

namespace BookStoreServer.WebApi.Mapping;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        // RegistorDto'dan alınan nesneler Usera dönüştürülebilir halde saklanır.
        CreateMap<RegisterDto, User>();

        // Book classından alınan nesneler BookDto'ya dönüştürülebilir halde saklanır.
        CreateMap<Book, BookDto>();
    }
}
