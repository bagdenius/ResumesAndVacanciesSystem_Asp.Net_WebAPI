using AutoMapper;
using Controllers.Abstract;
using Domain;
using Models;
using Services.Abstract;

namespace Controllers
{
    public class VacancyController : IController<VacancyModel>
    {
        private readonly IService<Vacancy> _service;
        private readonly IMapper _mapper;
        public VacancyController(IService<Vacancy> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public void Add(VacancyModel vacancy) =>
            _service.Add(_mapper.Map<Vacancy>(vacancy));

        public void Update(VacancyModel vacancy) =>
            _service.Update(_mapper.Map<Vacancy>(vacancy));

        public void Remove(int id) =>
            _service.Remove(id);

        public VacancyModel Get(int id) =>
            _mapper.Map<VacancyModel>(_service.Get(id));

        public List<VacancyModel> GetAll() =>
             _mapper.Map<List<VacancyModel>>(_service.GetAll());

        public void Save() => _service.Save();
    }
}
