using CommandsAndQueries.Exceptions;
using Entities;
using MediatR;
using UnitOfWOrk.Abstract;

namespace CommandsAndQueries.ResumeCommands.AddResume
{
    public class AddResumeCommandHandler : IRequestHandler<AddResumeCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddResumeCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Guid> Handle(AddResumeCommand request, CancellationToken cancellationToken)
        {
            if (_unitOfWork.Users.GetAsync(request.UserId, cancellationToken) == null)
                throw new NotFoundException(nameof(User), request.UserId);
            var resume = new Resume
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Title = request.Title,
                City = request.City,
                Position = request.Position,
                Salary = request.Salary,
                Employement = request.Employement,
                Experience = request.Experience,
                Content = request.Content,
                CreationDate = DateTime.Now
            };
            await _unitOfWork.Resumes.AddAsync(resume, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return resume.Id;
        }
    }
}
