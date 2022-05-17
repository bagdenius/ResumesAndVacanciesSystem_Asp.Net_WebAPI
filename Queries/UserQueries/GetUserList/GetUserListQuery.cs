using MediatR;
using ViewModels;

namespace Queries.UserQueries.GetUserList
{
    public class GetUserListQuery : IRequest<List<UserVM>>
    {

    }
}
