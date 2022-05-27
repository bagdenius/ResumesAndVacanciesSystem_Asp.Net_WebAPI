using AutoMapper;
using CommandsAndQueries.UserCommands.AddUser;
using CommandsAndQueries.UserCommands.UpdateUser;
using Entities;
using UI.Models.User;
using ViewModels;

namespace Mappers
{
    public class UserMapper : AutoMapper.Profile
    {
        public UserMapper()
        {
            CreateMap<Profile, UserVM>();
            CreateMap<AddUserModel, AddUserCommand>();
            CreateMap<UpdateUserModel, UpdateUserCommand>();
        }
    }
}
