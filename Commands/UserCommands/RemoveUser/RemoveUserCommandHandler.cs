using AutoMapper;
using Queries.Exceptions;
using Domain;
using MediatR;
using Services.Abstract;

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
            var user = await _service.GetAsync(request.Id, cancellationToken);
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(User), request.Id);
            _service.Remove(user.Id);
            await _service.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
