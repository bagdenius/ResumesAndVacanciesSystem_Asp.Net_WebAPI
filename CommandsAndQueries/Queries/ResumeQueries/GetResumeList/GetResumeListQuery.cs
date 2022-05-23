using MediatR;
using ViewModels;

namespace CommandsAndQueries.ResumeQueries.GetResumeList
{
    public class GetResumeListQuery : IRequest<List<ResumeVM>>
    {

    }
}
