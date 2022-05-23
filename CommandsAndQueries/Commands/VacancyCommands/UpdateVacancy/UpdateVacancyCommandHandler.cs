using CommandsAndQueries.Exceptions;
using Entities;
using MediatR;
using UnitOfWOrk.Abstract;

namespace CommandsAndQueries.VacancyCommands.UpdateVacancy
{
    public class UpdateVacancyCommandHandler : IRequestHandler<UpdateVacancyCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateVacancyCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Unit> Handle(UpdateVacancyCommand request, CancellationToken cancellationToken)
        {
            var vacancy = await _unitOfWork.Vacancies.GetAsync(request.Id, cancellationToken);
            if (vacancy == null || vacancy.Id != request.Id)
                throw new NotFoundException(nameof(Vacancy), request.Id);
            vacancy.Id = request.Id;
            vacancy.UserId = request.UserId;
            vacancy.Title = request.Title;
            vacancy.Description = request.Description;
            vacancy.City = request.City;
            vacancy.Company = request.Company;
            vacancy.Position = request.Position;
            vacancy.Salary = request.Salary;
            vacancy.Employement = request.Employement;
            vacancy.WorkingDays = request.WorkingDays;
            vacancy.WorkingHours = request.WorkingHours;
            vacancy.Experience = request.Experience;
            vacancy.Phone = request.Phone;
            vacancy.EditDate = DateTime.Now;
            await _unitOfWork.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
