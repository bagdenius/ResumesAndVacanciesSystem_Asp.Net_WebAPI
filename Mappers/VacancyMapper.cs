using AutoMapper;
using Domain;
using Entities;

namespace Mappers
{
    public class VacancyMapper : Profile
    {
        public VacancyMapper()
        {
            CreateMap<Vacancy, VacancyEntity>().ReverseMap();
        }
    }
}
