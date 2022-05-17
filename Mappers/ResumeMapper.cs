using AutoMapper;
using Domain;
using Entities;
using Models;

namespace Mappers
{
    public class ResumeMapper : Profile
    {
        public ResumeMapper()
        {
            CreateMap<Resume, ResumeEntity>().ReverseMap();
            CreateMap<Resume, ResumeModel>().ReverseMap();
        }
    }
}
