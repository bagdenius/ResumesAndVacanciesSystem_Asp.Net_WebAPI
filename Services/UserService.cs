using AutoMapper;
using Domain;
using Entities;
using Services.Abstract;
using UnitOfWOrk.Abstract;

namespace Services
{
    public class UserService : IService<User>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public void Add(User user) =>
            _unitOfWork.Users.Add(_mapper.Map<UserEntity>(user));

        public async Task AddAsync(User user, CancellationToken cancellationToken) =>
            await _unitOfWork.Users.AddAsync(_mapper.Map<UserEntity>(user), cancellationToken);

        public void Update(User user) =>
            _unitOfWork.Users.Update(_mapper.Map<UserEntity>(user));

        public void Remove(Guid id) =>
            _unitOfWork.Users.Remove(id);

        public void Remove(User user) =>
            _unitOfWork.Users.Remove(_mapper.Map<UserEntity>(user));

        public User Get(Guid id) =>
            _mapper.Map<User>(_unitOfWork.Users.Get(id));

        public async Task<User> GetAsync(Guid id, CancellationToken cancellationToken) =>
            _mapper.Map<User>(await _unitOfWork.Users.GetAsync(id, cancellationToken));

        public List<User> GetAll() =>
            _mapper.Map<List<User>>(_unitOfWork.Users.GetAll());

        public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken) =>
            _mapper.Map<List<User>>(await _unitOfWork.Users.GetAllAsync(cancellationToken));

        public void Save() => _unitOfWork.Save();

        public async Task SaveAsync(CancellationToken cancellationToken) =>
            await _unitOfWork.SaveAsync(cancellationToken);
    }
}
