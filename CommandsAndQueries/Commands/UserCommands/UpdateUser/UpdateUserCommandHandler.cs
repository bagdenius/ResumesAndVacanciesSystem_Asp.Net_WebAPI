using CommandsAndQueries.Exceptions;
using MediatR;
using UnitOfWork.Abstract;
using Entities;

namespace CommandsAndQueries.UserCommands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateUserCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Users.GetAsync(request.Id, cancellationToken);
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(User), request.Id);
            user.Id = request.Id;
            //user.Login = request.Login;
            //user.Password = request.Password;
            //user.Role = request.Role;
            user.Name = request.Name;
            user.Surname = request.Surname;
            user.Patronymic = request.Patronymic;
            user.Education = request.Education;
            user.Gender = request.Gender;
            user.BirthDate = request.BirthDate;
            user.City = request.City;
            user.Phone = request.Phone;
            user.Email = request.Email;
            await _unitOfWork.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
