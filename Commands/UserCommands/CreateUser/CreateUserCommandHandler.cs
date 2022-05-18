using AutoMapper;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Commands.UserCommands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IService<User> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new UserVM
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Surname = request.Surname,
                Patronymic = request.Patronymic,
                Education = request.Education,
                Gender = request.Gender,
                BirthDate = request.BirthDate,
                Role = request.Role,
                City = request.City,
                Phone = request.Phone,
                Email = request.Email,
                CreationDate = DateTime.Now
            };
            await _service.AddAsync(_mapper.Map<User>(user), cancellationToken);
            await _service.SaveAsync(cancellationToken);
            return user.Id;
        }
    }
}
