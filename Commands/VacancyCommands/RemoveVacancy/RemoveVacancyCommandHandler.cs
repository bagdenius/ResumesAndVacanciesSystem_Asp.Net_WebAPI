using AutoMapper;
using Commands.Exceptions;
using Domain;
using MediatR;
using Services.Abstract;

namespace Commands.VacancyCommands.RemoveVacancy
{
    public class RemoveVacancyCommandHandler : IRequestHandler<RemoveVacancyCommand>
    {
        private readonly IService<Vacancy> _service;
        private readonly IMapper _mapper;
        public RemoveVacancyCommandHandler(IService<Vacancy> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Unit> Handle(RemoveVacancyCommand request, CancellationToken cancellationToken)
        {
            var vacancy = await _service.GetAsync(request.Id, cancellationToken);
            if (vacancy == null || vacancy.Id != request.Id)
                throw new NotFoundException(nameof(Vacancy), request.Id);
            _service.Remove(vacancy);
            await _service.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
