using CommandsAndQueries.Exceptions;
using MediatR;
using UnitOfWOrk.Abstract;
using Entities;

namespace CommandsAndQueries.ResumeCommands.RemoveResume
{
    public class RemoveResumeCommandHandler : IRequestHandler<RemoveResumeCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemoveResumeCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Unit> Handle(RemoveResumeCommand request, CancellationToken cancellationToken)
        {
            var resume = await _unitOfWork.Resumes.GetAsync(request.Id, cancellationToken);
            if (resume == null || resume.Id != request.Id)
                throw new NotFoundException(nameof(Resume), request.Id);
            _unitOfWork.Resumes.Remove(resume);
            await _unitOfWork.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
