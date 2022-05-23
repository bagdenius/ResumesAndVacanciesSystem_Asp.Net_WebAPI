using CommandsAndQueries.Exceptions;
using MediatR;
using UnitOfWOrk.Abstract;
using Entities;

namespace CommandsAndQueries.ResumeCommands.UpdateResume
{
    public class UpdateResumeCommandHandler : IRequestHandler<UpdateResumeCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateResumeCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Unit> Handle(UpdateResumeCommand request, CancellationToken cancellationToken)
        {
            var resume = await _unitOfWork.Resumes.GetAsync(request.Id, cancellationToken);
            if (resume == null || resume.Id != request.Id)
                throw new NotFoundException(nameof(Resume), request.Id);
            resume.Id = request.Id;
            resume.UserId = request.UserId;
            resume.Title = request.Title;
            resume.City = request.City;
            resume.Position = request.Position;
            resume.Salary = request.Salary;
            resume.Employement = request.Employement;
            resume.Experience = request.Experience;
            resume.Content = request.Content;
            resume.EditDate = DateTime.Now;
            await _unitOfWork.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
