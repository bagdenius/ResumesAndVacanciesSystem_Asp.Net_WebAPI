using AutoMapper;
using Entities;
using ViewModels;

namespace CommandsAndQueries.EntityViewModelMappers
{
    public class UserVmMapper : Profile
    {
        public UserVmMapper()
        {
            CreateMap<User, UserVM>();
        }
    }
}
