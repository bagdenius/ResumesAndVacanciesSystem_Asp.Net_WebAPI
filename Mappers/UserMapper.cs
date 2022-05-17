using AutoMapper;
using Domain;
using Entities;
using ViewModels;

namespace Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserEntity>().ReverseMap();
            CreateMap<User, UserVM>().ReverseMap();
        }
    }
}
