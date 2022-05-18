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

        public async Task AddAsync(Resume resume, CancellationToken cancellationToken) =>
            await _unitOfWork.Resumes.AddAsync(_mapper.Map<ResumeEntity>(resume), cancellationToken);

        public void Update(Resume resume) =>
            _unitOfWork.Resumes.Update(_mapper.Map<ResumeEntity>(resume));

        public void Remove(Guid id) =>
            _unitOfWork.Resumes.Remove(id);

        public void Remove(Resume resume) =>
            _unitOfWork.Resumes.Remove(_mapper.Map<ResumeEntity>(resume));

        public Resume Get(Guid id) =>
            _mapper.Map<Resume>(_unitOfWork.Resumes.Get(id));

        public Task<Resume> GetAsync(Guid id, CancellationToken cancellationToken) =>
            _mapper.Map<Task<Resume>>(_unitOfWork.Resumes.GetAsync(id, cancellationToken));

        public List<Resume> GetAll() =>
            _mapper.Map<List<Resume>>(_unitOfWork.Resumes.GetAll());

        public Task<List<Resume>> GetAllAsync(CancellationToken cancellationToken) =>
            _mapper.Map<Task<List<Resume>>>(_unitOfWork.Resumes.GetAllAsync(cancellationToken));

        public void Save() => _unitOfWork.Save();

        public Task SaveAsync(CancellationToken cancellationToken) =>
            _unitOfWork.SaveAsync(cancellationToken);
    }
}
