using AutoMapper;
using Controllers.Abstract;
using Domain;
using Models;
using Services.Abstract;

namespace Controllers
{
    public class ResumeController : IController<ResumeModel>
    {
        private readonly IService<Resume> _service;
        private readonly IMapper _mapper;
        public ResumeController(IService<Resume> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public void Add(ResumeModel resume) =>
            _service.Add(_mapper.Map<Resume>(resume));

        public void Update(ResumeModel resume) =>
            _service.Update(_mapper.Map<Resume>(resume));

        public void Remove(int id) =>
            _service.Remove(id);

        public ResumeModel Get(int id) =>
            _mapper.Map<ResumeModel>(_service.Get(id));

        public List<ResumeModel> GetAll() =>
             _mapper.Map<List<ResumeModel>>(_service.GetAll());

        public void Save() => _service.Save();
    }
}
