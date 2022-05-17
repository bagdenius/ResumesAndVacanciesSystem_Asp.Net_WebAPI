using AutoMapper;
using Domain;
using Entities;
using ViewModels;

namespace Mappers
{
    public class ResumeMapper : Profile
    {
        public ResumeMapper()
        {
            CreateMap<Resume, ResumeEntity>().ReverseMap();
            CreateMap<Resume, ResumeVM>().ReverseMap();
        }
    }
}
