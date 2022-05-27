using CommandsAndQueries.Exceptions;
using MediatR;
using UnitOfWork.Abstract;
using Entities;

namespace CommandsAndQueries.UserCommands.RemoveUser
{
    public class RemoveUserCommandHandler : IRequestHandler<RemoveUserCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemoveUserCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Unit> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Users.GetAsync(request.Id, cancellationToken);
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(User), request.Id);
            _unitOfWork.Users.Remove(user);
            await _unitOfWork.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
