using Queries.Exceptions;
using MediatR;
using ViewModels;
using Services.Abstract;
using Domain;
using AutoMapper;

namespace Queries.UserCommands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        public UpdateUserCommandHandler(IService<User> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _service.Get(request.Id);
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(UserVM), request.Id);
            user.Id = request.Id;
            user.Name = request.Name;
            user.Surname = request.Surname;
            user.Patronymic = request.Patronymic;
            user.Education = request.Education;
            user.Gender = request.Gender;
            user.BirthDate = request.BirthDate;
            user.Role = request.Role;
            user.City = request.City;
            user.Phone = request.Phone;
            user.Email = request.Email;
            //_controller.Update(user);
            _service.Save();
            return Unit.Value;
        }
    }
}
