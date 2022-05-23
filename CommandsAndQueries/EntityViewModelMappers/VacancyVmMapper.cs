using AutoMapper;
using Entities;
using ViewModels;

namespace CommandsAndQueries.EntityViewModelMappers
{
    public class VacancyVmMapper : Profile
    {
        public VacancyVmMapper()
        {
            CreateMap<Vacancy, VacancyVM>();
        }
    }
}
