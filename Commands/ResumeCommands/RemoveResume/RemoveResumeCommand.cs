using MediatR;

namespace Queries.ResumeCommands.RemoveResume
{
    public class RemoveResumeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
