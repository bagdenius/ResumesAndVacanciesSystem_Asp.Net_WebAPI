using MediatR;
using ViewModels;

namespace CommandsAndQueries.UserQueries.GetUser
{
    public class GetUserQuery : IRequest<UserVM>
    {
        public Guid Id { get; set; }
    }
}
