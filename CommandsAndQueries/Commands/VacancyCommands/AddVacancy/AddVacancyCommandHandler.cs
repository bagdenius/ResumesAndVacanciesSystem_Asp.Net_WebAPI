using Entities;
using MediatR;
using UnitOfWOrk.Abstract;

namespace CommandsAndQueries.VacancyCommands.AddVacancy
{
    public class AddVacancyCommandHandler : IRequestHandler<AddVacancyCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddVacancyCommandHandler(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public async Task<Guid> Handle(AddVacancyCommand request, CancellationToken cancellationToken)
        {
            var vacancy = new Vacancy
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                City = request.City,
                Company = request.Company,
                Position = request.Position,
                Salary = request.Salary,
                Employement = request.Employement,
                WorkingDays = request.WorkingDays,
                WorkingHours = request.WorkingHours,
                Experience = request.Experience,
                Phone = request.Phone,
                CreationDate = DateTime.Now
            };
            await _unitOfWork.Vacancies.AddAsync(vacancy, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return vacancy.Id;
        }
    }
}
