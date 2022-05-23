using MediatR;
using ViewModels;

namespace CommandsAndQueries.UserQueries.GetUserList
{
    public class GetUserListQuery : IRequest<List<UserVM>>
    {

    }
}
