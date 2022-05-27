using Entities.Enums;
using MediatR;

namespace CommandsAndQueries.ResumeCommands.AddResume
{
    public class AddResumeCommand : IRequest<Guid>
    {
        public bool IsSalarySpecified { get; set; }

        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public Employement Employement { get; set; }
        public string Content { get; set; }
    }
}
