using MediatR;

namespace Commands.ResumeCommands.RemoveResume
{
    public class RemoveResumeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
