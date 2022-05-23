using MediatR;

namespace CommandsAndQueries.UserCommands.RemoveUser
{
    public class RemoveUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
