using MediatR;

namespace Queries.UserCommands.RemoveUser
{
    public class RemoveUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
