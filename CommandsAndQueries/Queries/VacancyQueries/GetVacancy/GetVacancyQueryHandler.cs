using AutoMapper;
using MediatR;
using CommandsAndQueries.Exceptions;
using ViewModels;
using UnitOfWork.Abstract;
using Entities;

namespace CommandsAndQueries.VacancyQueries.GetVacancy
{
    public class GetVacancyQueryHandler : IRequestHandler<GetVacancyQuery, VacancyVM>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetVacancyQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public async Task<VacancyVM> Handle(GetVacancyQuery request, CancellationToken cancellationToken)
        {
            var vacancy = await _unitOfWork.Vacancies.GetAsync(request.Id, cancellationToken);
            if (vacancy == null || vacancy.Id != request.Id)
                throw new NotFoundException(nameof(Vacancy), request.Id);
            return _mapper.Map<VacancyVM>(vacancy);
        }
    }
}
