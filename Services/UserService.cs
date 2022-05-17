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

        public void Update(User user) =>
            _unitOfWork.Users.Update(_mapper.Map<UserEntity>(user));

        public void Remove(int id) =>
            _unitOfWork.Users.Remove(id);

        public User Get(int id) =>
            _mapper.Map<User>(_unitOfWork.Users.Get(id));

        public List<User> GetAll() =>
            _mapper.Map<List<User>>(_unitOfWork.Users.GetAll());

        public void Save() => _unitOfWork.Save();
    }
}
