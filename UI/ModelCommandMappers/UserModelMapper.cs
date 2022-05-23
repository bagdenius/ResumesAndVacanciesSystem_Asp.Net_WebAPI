using AutoMapper;
using CommandsAndQueries.UserCommands.AddUser;
using CommandsAndQueries.UserCommands.UpdateUser;
using UI.Models.User;

namespace UI.ModelCommandMappers
{
    public class UserModelMapper : Profile
    {
        public UserModelMapper()
        {
            CreateMap<AddUserModel, AddUserCommand>();
            CreateMap<UpdateUserModel, UpdateUserCommand>();
        }
    }
}
