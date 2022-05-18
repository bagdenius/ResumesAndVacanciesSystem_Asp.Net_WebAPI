using MediatR;
using ViewModels;

namespace Commands.UserQueries.GetUser
{
    public class GetUserQuery : IRequest<UserVM>
    {
        public Guid Id { get; set; }
    }
}
