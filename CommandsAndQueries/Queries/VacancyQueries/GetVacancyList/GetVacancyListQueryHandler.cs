using AutoMapper;
using MediatR;
using UnitOfWork.Abstract;
using ViewModels;

namespace CommandsAndQueries.VacancyQueries.GetVacancyList
{
    public class GetVacancyListQueryHandler : IRequestHandler<GetVacancyListQuery, List<VacancyVM>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetVacancyListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public async Task<List<VacancyVM>> Handle(GetVacancyListQuery request, CancellationToken cancellationToken)
        {
            var vacancies = await _unitOfWork.Vacancies.GetAllAsync(cancellationToken);
            return _mapper.Map<List<VacancyVM>>(vacancies);
        }
    }
}
