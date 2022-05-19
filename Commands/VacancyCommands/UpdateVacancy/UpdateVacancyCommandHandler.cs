using AutoMapper;
using Queries.Exceptions;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Queries.VacancyCommands.UpdateVacancy
{
    public class UpdateVacancyCommandHandler : IRequestHandler<UpdateVacancyCommand>
    {
        private readonly IService<Vacancy> _service;
        private readonly IMapper _mapper;
        public UpdateVacancyCommandHandler(IService<Vacancy> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Unit> Handle(UpdateVacancyCommand request, CancellationToken cancellationToken)
        {
            var vacancy = _mapper.Map<VacancyVM>(await _service.GetAsync(request.Id, cancellationToken));
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
            await _service.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
