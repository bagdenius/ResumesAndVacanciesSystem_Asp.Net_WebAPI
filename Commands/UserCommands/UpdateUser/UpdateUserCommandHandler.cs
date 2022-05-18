using Commands.Exceptions;
using MediatR;
using ViewModels;
using Services.Abstract;
using Domain;
using AutoMapper;

namespace Commands.UserCommands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        public UpdateUserCommandHandler(IService<User> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<UserVM>(await _service.GetAsync(request.Id, cancellationToken));
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(User), request.Id);
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
            await _service.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
