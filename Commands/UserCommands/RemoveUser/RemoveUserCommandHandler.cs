using AutoMapper;
using Queries.Exceptions;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Queries.UserCommands.RemoveUser
{
    public class RemoveUserCommandHandler : IRequestHandler<RemoveUserCommand>
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        public RemoveUserCommandHandler(IService<User> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Unit> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<UserVM>(_service.Get(request.Id));
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(UserVM), request.Id);
            _service.Remove(user.Id);
            _service.Save();
            return Unit.Value;
        }
    }
}
