using AutoMapper;
using CommandsAndQueries.ResumeCommands.AddResume;
using CommandsAndQueries.ResumeCommands.UpdateResume;
using UI.Models.Resume;

namespace UI.ModelCommandMappers
{
    public class ResumeModelMapper : Profile
    {
        public ResumeModelMapper()
        {
            CreateMap<AddResumeModel, AddResumeCommand>();
            CreateMap<UpdateResumeModel, UpdateResumeCommand>();
        }
    }
}
