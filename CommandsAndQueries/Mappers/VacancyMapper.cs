using AutoMapper;
using CommandsAndQueries.VacancyCommands.AddVacancy;
using CommandsAndQueries.VacancyCommands.UpdateVacancy;
using Entities;
using UI.Models.Vacancy;
using ViewModels;

namespace Mappers
{
    public class VacancyMapper : Profile
    {
        public VacancyMapper()
        {
            CreateMap<Vacancy, VacancyVM>();
            CreateMap<AddVacancyModel, AddVacancyCommand>();
            CreateMap<UpdateVacancyModel, UpdateVacancyCommand>();
        }
    }
}
