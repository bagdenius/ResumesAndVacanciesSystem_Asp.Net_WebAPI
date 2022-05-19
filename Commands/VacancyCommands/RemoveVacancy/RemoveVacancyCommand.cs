using MediatR;

namespace Queries.VacancyCommands.RemoveVacancy
{
    public class RemoveVacancyCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
