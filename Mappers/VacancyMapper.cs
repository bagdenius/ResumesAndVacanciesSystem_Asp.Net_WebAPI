using AutoMapper;
using Domain;
using Entities;
using Models;

namespace Mappers
{
    public class VacancyMapper : Profile
    {
        public VacancyMapper()
        {
            CreateMap<Vacancy, VacancyEntity>().ReverseMap();
            CreateMap<Vacancy, VacancyModel>().ReverseMap();
        }
    }
}
