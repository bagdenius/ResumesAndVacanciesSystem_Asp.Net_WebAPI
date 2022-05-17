using AutoMapper;
using Domain;
using Entities;
using Services.Abstract;
using UnitOfWOrk.Abstract;

namespace Services
{
    public class ResumeService : IService<Resume>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ResumeService(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public void Add(Resume resume) =>
            _unitOfWork.Resumes.Add(_mapper.Map<ResumeEntity>(resume));

        public void Update(Resume resume) =>
            _unitOfWork.Resumes.Update(_mapper.Map<ResumeEntity>(resume));

        public void Remove(int id) =>
            _unitOfWork.Resumes.Remove(id);

        public Resume Get(int id) =>
            _mapper.Map<Resume>(_unitOfWork.Resumes.Get(id));

        public List<Resume> GetAll() =>
            _mapper.Map<List<Resume>>(_unitOfWork.Resumes.GetAll());

        public void Save() => _unitOfWork.Save();
    }
}
