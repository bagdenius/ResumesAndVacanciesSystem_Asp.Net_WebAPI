using MediatR;
using ViewModels;

namespace Commands.UserQueries.GetUserList
{
    public class GetUserListQuery : IRequest<List<UserVM>>
    {

    }
}
