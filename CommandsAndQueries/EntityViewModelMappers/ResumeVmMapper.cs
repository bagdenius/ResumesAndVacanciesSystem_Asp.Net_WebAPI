using AutoMapper;
using Entities;
using ViewModels;

namespace CommandsAndQueries.EntityViewModelMappers
{
    public class ResumeVmMapper : Profile
    {
        public ResumeVmMapper()
        {
            CreateMap<Resume, ResumeVM>();
        }
    }
}
