using AutoMapper;
using Domain;
using Entities;
using Models;

namespace Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserEntity>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
