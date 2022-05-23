using MediatR;

namespace CommandsAndQueries.ResumeCommands.RemoveResume
{
    public class RemoveResumeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
