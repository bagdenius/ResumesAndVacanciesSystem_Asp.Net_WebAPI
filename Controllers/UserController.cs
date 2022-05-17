using AutoMapper;
using Controllers.Abstract;
using Domain;
using Models;
using Services.Abstract;

namespace Controllers
{
    public class UserController : IController<UserModel>
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        public UserController(IService<User> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public void Add(UserModel user) =>
            _service.Add(_mapper.Map<User>(user));

        public void Update(UserModel user) =>
            _service.Update(_mapper.Map<User>(user));

        public void Remove(int id) =>
            _service.Remove(id);

        public UserModel Get(int id) =>
            _mapper.Map<UserModel>(_service.Get(id));

        public List<UserModel> GetAll() =>
             _mapper.Map<List<UserModel>>(_service.GetAll());

        public void Save() => _service.Save();
    }
}
