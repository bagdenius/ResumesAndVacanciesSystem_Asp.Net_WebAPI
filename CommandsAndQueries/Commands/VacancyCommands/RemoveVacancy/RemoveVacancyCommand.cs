using MediatR;

namespace CommandsAndQueries.VacancyCommands.RemoveVacancy
{
    public class RemoveVacancyCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
