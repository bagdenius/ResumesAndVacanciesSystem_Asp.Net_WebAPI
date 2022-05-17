using AutoMapper;
using Domain;
using Entities;
using Services.Abstract;
using UnitOfWOrk.Abstract;

namespace Services
{
    public class VacancyService : IService<Vacancy>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VacancyService(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public void Add(Vacancy vacancy) =>
            _unitOfWork.Vacancies.Add(_mapper.Map<VacancyEntity>(vacancy));

        public void Update(Vacancy vacancy) =>
            _unitOfWork.Vacancies.Update(_mapper.Map<VacancyEntity>(vacancy));

        public void Remove(Guid id) =>
            _unitOfWork.Vacancies.Remove(id);

        public Vacancy Get(Guid id) =>
            _mapper.Map<Vacancy>(_unitOfWork.Vacancies.Get(id));

        public List<Vacancy> GetAll() =>
            _mapper.Map<List<Vacancy>>(_unitOfWork.Vacancies.GetAll());

        public void Save() => _unitOfWork.Save();
    }
}
