using MediatR;

namespace Queries.VacancyCommands.CreateVacancy
{
    public class CreateVacancyCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public string Employement { get; set; }
        public int WorkingDays { get; set; }
        public string WorkingHours { get; set; }
        public int Experience { get; set; }
        public string Phone { get; set; }
    }
}
