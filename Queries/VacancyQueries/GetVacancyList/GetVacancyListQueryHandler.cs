using AutoMapper;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Queries.VacancyQueries.GetVacancyList
{
    public class GetVacancyListQueryHandler : IRequestHandler<GetVacancyListQuery, List<VacancyVM>>
    {
        private readonly IService<Vacancy> _service;
        private readonly IMapper _mapper;
        public GetVacancyListQueryHandler(IService<Vacancy> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<List<VacancyVM>> Handle(GetVacancyListQuery request, CancellationToken cancellationToken)
        {
            var vacancies = await _service.GetAllAsync(cancellationToken);
            return _mapper.Map<List<VacancyVM>>(vacancies);
        }
    }
}
