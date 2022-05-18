using AutoMapper;
using Domain;
using MediatR;
using Queries.Exceptions;
using Services.Abstract;
using ViewModels;

namespace Queries.VacancyQueries.GetVacancy
{
    public class GetVacancyQueryHandler : IRequestHandler<GetVacancyQuery, VacancyVM>
    {
        private readonly IService<Vacancy> _service;
        private readonly IMapper _mapper;
        public GetVacancyQueryHandler(IService<Vacancy> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<VacancyVM> Handle(GetVacancyQuery request, CancellationToken cancellationToken)
        {
            var vacancy = await _service.GetAsync(request.Id, cancellationToken);
            if (vacancy == null || vacancy.Id != request.Id)
                throw new NotFoundException(nameof(Vacancy), request.Id);
            return _mapper.Map<VacancyVM>(vacancy);
        }
    }
}
