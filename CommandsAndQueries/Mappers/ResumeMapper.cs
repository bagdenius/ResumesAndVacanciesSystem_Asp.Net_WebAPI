using AutoMapper;
using CommandsAndQueries.ResumeCommands.AddResume;
using CommandsAndQueries.ResumeCommands.UpdateResume;
using Entities;
using UI.Models.Resume;
using ViewModels;

namespace Mappers
{
    public class ResumeMapper : Profile
    {
        public ResumeMapper()
        {
            CreateMap<Resume, ResumeVM>();
            CreateMap<AddResumeModel, AddResumeCommand>();
            CreateMap<UpdateResumeModel, UpdateResumeCommand>();
        }
    }
}
