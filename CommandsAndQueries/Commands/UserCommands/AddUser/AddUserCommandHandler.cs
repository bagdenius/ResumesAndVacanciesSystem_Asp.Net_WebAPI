using Entities;
using MediatR;
using UnitOfWOrk.Abstract;

namespace CommandsAndQueries.UserCommands.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddUserCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Guid> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
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
            await _unitOfWork.Users.AddAsync(user, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return user.Id;
        }
    }
}
