using AutoMapper;
using CommandsAndQueries.VacancyCommands.AddVacancy;
using CommandsAndQueries.VacancyCommands.UpdateVacancy;
using UI.Models.Vacancy;

namespace UI.ModelCommandMappers
{
    public class VacancyModelMapper : Profile
    {
        public VacancyModelMapper()
        {
            CreateMap<AddVacancyModel, AddVacancyCommand>();
            CreateMap<UpdateVacancyModel, UpdateVacancyCommand>();
        }
    }
}
