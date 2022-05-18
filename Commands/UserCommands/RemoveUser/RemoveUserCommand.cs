using MediatR;

namespace Commands.UserCommands.RemoveUser
{
    public class RemoveUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
