using MediatR;

namespace Commands.VacancyCommands.RemoveVacancy
{
    public class RemoveVacancyCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
