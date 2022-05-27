using Entities.Enums;
using MediatR;

namespace CommandsAndQueries.VacancyCommands.UpdateVacancy
{
    public class UpdateVacancyCommand : IRequest
    {
        public bool IsSalarySpecified { get; set; }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public Employement Employement { get; set; }
        public WorkingDays WorkingDays { get; set; }
        public WorkingHours WorkingHours { get; set; }
        public string Phone { get; set; }
    }
}
