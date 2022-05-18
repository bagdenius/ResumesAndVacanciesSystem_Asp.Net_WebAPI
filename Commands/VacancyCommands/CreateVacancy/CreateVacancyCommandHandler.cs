using AutoMapper;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Commands.VacancyCommands.CreateVacancy
{
    public class CreateVacancyCommandHandler : IRequestHandler<CreateVacancyCommand, Guid>
    {
        private readonly IService<Vacancy> _service;
        private readonly IMapper _mapper;
        public CreateVacancyCommandHandler(IService<Vacancy> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Guid> Handle(CreateVacancyCommand request, CancellationToken cancellationToken)
        {
            var vacancy = new VacancyVM
            {
                Id = Guid.NewGuid(),
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
            await _service.AddAsync(_mapper.Map<Vacancy>(vacancy), cancellationToken);
            await _service.SaveAsync(cancellationToken);
            return vacancy.Id;
        }
    }
}
