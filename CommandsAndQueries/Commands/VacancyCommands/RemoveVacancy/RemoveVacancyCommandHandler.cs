using CommandsAndQueries.Exceptions;
using Entities;
using MediatR;
using UnitOfWork.Abstract;

namespace CommandsAndQueries.VacancyCommands.RemoveVacancy
{
    public class RemoveVacancyCommandHandler : IRequestHandler<RemoveVacancyCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemoveVacancyCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Unit> Handle(RemoveVacancyCommand request, CancellationToken cancellationToken)
        {
            var vacancy = await _unitOfWork.Vacancies.GetAsync(request.Id, cancellationToken);
            if (vacancy == null || vacancy.Id != request.Id)
                throw new NotFoundException(nameof(Vacancy), request.Id);
            _unitOfWork.Vacancies.Remove(vacancy);
            await _unitOfWork.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
