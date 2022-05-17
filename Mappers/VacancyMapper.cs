using AutoMapper;
using Domain;
using Entities;
using ViewModels;

namespace Mappers
{
    public class VacancyMapper : Profile
    {
        public VacancyMapper()
        {
            CreateMap<Vacancy, VacancyEntity>().ReverseMap();
            CreateMap<Vacancy, VacancyVM>().ReverseMap();
        }
    }
}
