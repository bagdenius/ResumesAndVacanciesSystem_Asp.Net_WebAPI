using MediatR;
using ViewModels;

namespace Queries.UserQueries.GetUser
{
    public class GetUserQuery : IRequest<UserVM>
    {
        public Guid Id { get; set; }
    }
}
