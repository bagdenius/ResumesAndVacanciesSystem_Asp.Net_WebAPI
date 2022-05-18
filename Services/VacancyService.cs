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

        public async Task AddAsync(Vacancy vacancy, CancellationToken cancellationToken) =>
            await _unitOfWork.Vacancies.AddAsync(_mapper.Map<VacancyEntity>(vacancy), cancellationToken);

        public void Update(Vacancy vacancy) =>
            _unitOfWork.Vacancies.Update(_mapper.Map<VacancyEntity>(vacancy));

        public void Remove(Guid id) =>
            _unitOfWork.Vacancies.Remove(id);

        public void Remove(Vacancy vacancy) =>
            _unitOfWork.Vacancies.Remove(_mapper.Map<VacancyEntity>(vacancy));

        public Vacancy Get(Guid id) =>
            _mapper.Map<Vacancy>(_unitOfWork.Vacancies.Get(id));

        public Task<Vacancy> GetAsync(Guid id, CancellationToken cancellationToken) =>
            _mapper.Map<Task<Vacancy>>(_unitOfWork.Vacancies.GetAsync(id, cancellationToken));

        public List<Vacancy> GetAll() =>
            _mapper.Map<List<Vacancy>>(_unitOfWork.Vacancies.GetAll());

        public Task<List<Vacancy>> GetAllAsync(CancellationToken cancellationToken) =>
            _mapper.Map<Task<List<Vacancy>>>(_unitOfWork.Vacancies.GetAllAsync(cancellationToken));

        public void Save() => _unitOfWork.Save();

        public Task SaveAsync(CancellationToken cancellationToken) =>
            _unitOfWork.SaveAsync(cancellationToken);
    }
}
